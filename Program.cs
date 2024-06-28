using System.Security.Claims;
using HotelBookingAPI.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<HotelBookingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add Identity
builder.Services.AddIdentity<User, UserRole>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = false;

    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
})
    .AddRoles<UserRole>()
    .AddEntityFrameworkStores<HotelBookingDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Seed Admin User
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var userManager = services.GetRequiredService<UserManager<User>>();
var roleManager = services.GetRequiredService<RoleManager<UserRole>>();
await SeedAdminUserAsync(userManager, roleManager);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/// <summary>
/// Seed Admin User
/// </summary>
async Task SeedAdminUserAsync(UserManager<User> userManager, RoleManager<UserRole> roleManager)
{
    // Defining Admin Role
    string adminRoleName = "Admin";
    string adminRoleDescription = "Administrator Role";

    // Defining Admin User
    string adminEmail = "admin@example.com";
    string adminPassword = "AdminPassword123!";
    string adminUserName = "admin";

    // Checking if Admin Role exists
    if (!await roleManager.RoleExistsAsync(adminRoleName))
    {
        // Creating Admin Role if it does not exist
        var adminRole = new UserRole
        {
            Name = adminRoleName,
            Description = adminRoleDescription
        };

        await roleManager.CreateAsync(adminRole);
    }

    // Checking if Admin User exists    
    if (await userManager.FindByEmailAsync(adminEmail) == null)
    {
        // Creating Admin User if it does not exist
        var adminUser = new User
        {
            UserName = adminUserName,
            Email = adminEmail,
            IsActive = true,
            LastLogin = DateTime.UtcNow,
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(adminUser, adminPassword);

        if (result.Succeeded)
        {
            // Adding Admin Role to Admin User
            await userManager.AddToRoleAsync(adminUser, adminRoleName);

            // Adding Claims
            await userManager.AddClaimAsync(adminUser, new Claim(ClaimTypes.Role, adminRoleName));
            await userManager.AddClaimAsync(adminUser, new Claim(ClaimTypes.Email, adminEmail));
        }
    }
}