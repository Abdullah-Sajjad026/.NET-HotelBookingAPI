using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingAPI.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAndJoinTablesSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Users_UserId",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentBatches_Users_UserId",
                table: "PaymentBatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomAmenities",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cancellations",
                keyColumn: "CancellationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "FeedbackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RefundMethods",
                keyColumn: "RefundMethodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Refunds",
                keyColumn: "RefundId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservationGuests",
                keyColumns: new[] { "GuestId", "ReservationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ReservationGuests",
                keyColumns: new[] { "GuestId", "ReservationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ReservationGuests",
                keyColumns: new[] { "GuestId", "ReservationId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RoomAmenities",
                keyColumns: new[] { "AmenityId", "RoomId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "GuestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PaymentBatches",
                keyColumn: "PaymentBatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentBatches",
                keyColumn: "PaymentBatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RefundMethods",
                keyColumn: "RefundMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CountryStates",
                keyColumn: "CountryStateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "RoomTypeId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "AspNetUsers",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                comment: "The user who made the reservation",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The user who made the reservation");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "PaymentBatches",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Guests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AspNetUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomAmenities",
                table: "RoomAmenities",
                columns: new[] { "RoomId", "AmenityId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_AmenityId",
                table: "RoomAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_AspNetUsers_UserId",
                table: "Guests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentBatches_AspNetUsers_UserId",
                table: "PaymentBatches",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_AspNetUsers_UserId",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentBatches_AspNetUsers_UserId",
                table: "PaymentBatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomAmenities",
                table: "RoomAmenities");

            migrationBuilder.DropIndex(
                name: "IX_RoomAmenities_AmenityId",
                table: "RoomAmenities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Users",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Reservations",
                type: "int",
                nullable: false,
                comment: "The user who made the reservation",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "The user who made the reservation");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PaymentBatches",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Guests",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomAmenities",
                table: "RoomAmenities",
                columns: new[] { "AmenityId", "RoomId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleId);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityId", "CreatedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(856), "Free Wi-Fi", true, false, "Free Wi-Fi", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(857) },
                    { 2, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(862), "Free Parking", true, false, "Free Parking", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(863) },
                    { 3, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(865), "Swimming Pool", true, false, "Swimming Pool", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(865) },
                    { 4, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(867), "Gym", true, false, "Gym", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(867) },
                    { 5, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(869), "Spa", true, false, "Spa", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(869) },
                    { 6, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(870), "Restaurant", true, false, "Restaurant", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(871) },
                    { 7, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(872), "Bar", true, false, "Bar", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(873) },
                    { 8, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(874), "Room Service", true, false, "Room Service", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(875) },
                    { 9, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(876), "Airport Shuttle", true, false, "Airport Shuttle", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(877) },
                    { 10, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(878), "Pet Friendly", true, false, "Pet Friendly", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(879) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "CountryName", "IsActive" },
                values: new object[,]
                {
                    { 1, "US", "United States", true },
                    { 2, "CA", "Canada", true },
                    { 3, "UK", "United Kingdom", true },
                    { 4, "PK", "Pakistan", true }
                });

            migrationBuilder.InsertData(
                table: "RefundMethods",
                columns: new[] { "RefundMethodId", "CreatedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(203), "Refund via bank transfer", true, false, "Bank Transfer", new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(203) },
                    { 2, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(223), "Refund via credit card", true, false, "Credit Card", new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(223) }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "RoomTypeId", "AccessibilityFeatures", "CreatedAt", "Description", "IsActive", "TypeName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Wheelchair Accessible", new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3860), "Single Bed", true, "Single", new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3867) },
                    { 2, null, new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3929), "Double Bed", true, "Double", new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3929) },
                    { 3, "Accessible Bathroom, Wheelchair Accessible, Roll-in Shower", new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3932), "Suite", true, "Suite", new DateTime(2024, 6, 18, 6, 43, 15, 549, DateTimeKind.Utc).AddTicks(3933) }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "CreatedAt", "Description", "IsActive", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 18, 6, 43, 15, 425, DateTimeKind.Utc).AddTicks(8959), "Admin role has full access to all resources", true, "Admin" },
                    { 2, new DateTime(2024, 6, 18, 6, 43, 15, 425, DateTimeKind.Utc).AddTicks(8969), "User role has limited access to resources", true, "User" }
                });

            migrationBuilder.InsertData(
                table: "CountryStates",
                columns: new[] { "CountryStateId", "CountryId", "StateCode", "StateName" },
                values: new object[,]
                {
                    { 1, 1, "CA", "California" },
                    { 2, 1, "NY", "New York" },
                    { 3, 2, "ON", "Ontario" },
                    { 4, 2, "QC", "Quebec" },
                    { 5, 3, "ENG", "England" },
                    { 6, 3, "SCT", "Scotland" },
                    { 7, 4, "PB", "Punjab" },
                    { 8, 4, "SD", "Sindh" }
                });

            migrationBuilder.InsertData(
                table: "Refunds",
                columns: new[] { "RefundId", "Amount", "CreatedAt", "Description", "IsDeleted", "PaymentId", "ProcessedByUserId", "RefundDate", "RefundMethodId", "UpdatedAt" },
                values: new object[] { 1, 50.00m, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(362), "Refund for cancellation", false, 1, 1, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(366), 1, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(362) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "BedType", "CreatedAt", "IsActive", "IsDeleted", "Price", "RoomNumber", "RoomTypeId", "Status", "UpdatedAt", "ViewType" },
                values: new object[,]
                {
                    { 1, "Single", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(350), true, false, 100m, "101", 1, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(364), "City" },
                    { 2, "Double", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(400), true, false, 150m, "102", 2, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(400), "Sea" },
                    { 3, "King", new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(404), true, false, 200m, "103", 3, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(405), "Mountain" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "IsActive", "IsDeleted", "LastLogin", "PasswordHash", "RoleId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 6, 18, 6, 43, 15, 425, DateTimeKind.Utc).AddTicks(9309), "admin@jabsihotels.com", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$10$UQU6PeeUDMoHlVbpDOUxru:$2a$10$UQU6PeeUDMoHlVbpDOUxruaFVR6y8MEYpN44Fy1ZMN3yZPf/59sBm", 1, new DateTime(2024, 6, 18, 6, 43, 15, 425, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "GuestId", "Address", "Age", "CountryStateId", "CreatedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Phone", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "1234 Elm St", 25, 1, new DateTime(2024, 6, 18, 6, 43, 14, 684, DateTimeKind.Utc).AddTicks(9250), "johndoe@example.com", "John", true, false, "Doe", "1234567890", new DateTime(2024, 6, 18, 6, 43, 14, 684, DateTimeKind.Utc).AddTicks(9251), null },
                    { 2, "5678 Oak St", 30, 2, new DateTime(2024, 6, 18, 6, 43, 14, 685, DateTimeKind.Utc).AddTicks(1030), "janedoe@example.com", "Jane", true, false, "Doe", "0987654321", new DateTime(2024, 6, 18, 6, 43, 14, 685, DateTimeKind.Utc).AddTicks(1030), null },
                    { 3, "2468 Pine St", 35, 3, new DateTime(2024, 6, 18, 6, 43, 14, 685, DateTimeKind.Utc).AddTicks(1036), "alicesmith@example.com", "Alice", true, false, "Smith", "1357924680", new DateTime(2024, 6, 18, 6, 43, 14, 685, DateTimeKind.Utc).AddTicks(1037), null }
                });

            migrationBuilder.InsertData(
                table: "PaymentBatches",
                columns: new[] { "PaymentBatchId", "CreatedAt", "IsDeleted", "IsPaid", "PaymentDate", "TotalAmount", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8680), false, true, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8705), 100.00m, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8681), 1 },
                    { 2, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8721), false, true, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8723), 200.00m, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8721), 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "BookingDate", "CheckInDate", "CheckOutDate", "CreatedAt", "IsActive", "IsDeleted", "NumberOfGuests", "RoomId", "Status", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 6, 19, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7945), new DateTime(2024, 6, 21, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7906), true, false, 2, 1, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7907), 1 },
                    { 2, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7978), new DateTime(2024, 6, 17, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 6, 20, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8027), new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7976), true, false, 1, 2, 2, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(7976), 1 },
                    { 3, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 6, 20, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 6, 22, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8033), new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8030), true, false, 3, 3, 4, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(8030), 1 }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenities",
                columns: new[] { "AmenityId", "RoomId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 },
                    { 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "Cancellations",
                columns: new[] { "CancellationId", "CancellationDate", "CancellationFee", "CreatedAt", "IsDeleted", "Reason", "ReservationId", "Status", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(14), 50.00m, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(11), false, "Change of plans", 1, 0, new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Comment", "FeedbackDate", "GuestId", "IsDeleted", "Rating", "ReservationId" },
                values: new object[,]
                {
                    { 1, "Great service!", new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(564), 1, false, 5, 1 },
                    { 2, "Good service!", new DateTime(2024, 6, 18, 6, 43, 15, 552, DateTimeKind.Utc).AddTicks(568), 2, false, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "CreatedAt", "IsDeleted", "PaymentBatchId", "ReservationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 50.00m, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9773), false, 1, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9774) },
                    { 2, 50.00m, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9782), false, 1, 1, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9782) },
                    { 3, 200.00m, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9784), false, 2, 2, new DateTime(2024, 6, 18, 6, 43, 15, 551, DateTimeKind.Utc).AddTicks(9785) }
                });

            migrationBuilder.InsertData(
                table: "ReservationGuests",
                columns: new[] { "GuestId", "ReservationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Users_UserId",
                table: "Guests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentBatches_Users_UserId",
                table: "PaymentBatches",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "UserRoles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
