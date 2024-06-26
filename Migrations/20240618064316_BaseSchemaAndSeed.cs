﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingAPI.Migrations
{
    /// <inheritdoc />
    public partial class BaseSchemaAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "RefundMethods",
                columns: table => new
                {
                    RefundMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundMethods", x => x.RefundMethodId);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessibilityFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "CountryStates",
                columns: table => new
                {
                    CountryStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryStates", x => x.CountryStateId);
                    table.ForeignKey(
                        name: "FK_CountryStates_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                columns: table => new
                {
                    RefundId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefundMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    ProcessedByUserId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RefundDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.RefundId);
                    table.ForeignKey(
                        name: "FK_Refunds_RefundMethods_RefundMethodId",
                        column: x => x.RefundMethodId,
                        principalTable: "RefundMethods",
                        principalColumn: "RefundMethodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    BedType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRoles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomAmenities",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenities", x => new { x.AmenityId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_RoomAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "AmenityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomAmenities_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CountryStateId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guests_CountryStates_CountryStateId",
                        column: x => x.CountryStateId,
                        principalTable: "CountryStates",
                        principalColumn: "CountryStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PaymentBatches",
                columns: table => new
                {
                    PaymentBatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentBatches", x => x.PaymentBatchId);
                    table.ForeignKey(
                        name: "FK_PaymentBatches_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "The user who made the reservation"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    PaymentBatchId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentBatches_PaymentBatchId",
                        column: x => x.PaymentBatchId,
                        principalTable: "PaymentBatches",
                        principalColumn: "PaymentBatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cancellations",
                columns: table => new
                {
                    CancellationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    CancellationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CancellationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancellations", x => x.CancellationId);
                    table.ForeignKey(
                        name: "FK_Cancellations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeedbackDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservationGuests",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationGuests", x => new { x.ReservationId, x.GuestId });
                    table.ForeignKey(
                        name: "FK_ReservationGuests_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationGuests_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Cancellations_ReservationId",
                table: "Cancellations",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryCode",
                table: "Countries",
                column: "CountryCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CountryStates_CountryId",
                table: "CountryStates",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryStates_StateCode",
                table: "CountryStates",
                column: "StateCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_GuestId",
                table: "Feedbacks",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ReservationId",
                table: "Feedbacks",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_CountryStateId",
                table: "Guests",
                column: "CountryStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_UserId",
                table: "Guests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentBatches_UserId",
                table: "PaymentBatches",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentBatchId",
                table: "Payments",
                column: "PaymentBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundMethodId",
                table: "Refunds",
                column: "RefundMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationGuests_GuestId",
                table: "ReservationGuests",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomId_CheckInDate_CheckOutDate",
                table: "Reservations",
                columns: new[] { "RoomId", "CheckInDate", "CheckOutDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenities_RoomId",
                table: "RoomAmenities",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypes_TypeName",
                table: "RoomTypes",
                column: "TypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancellations");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Refunds");

            migrationBuilder.DropTable(
                name: "ReservationGuests");

            migrationBuilder.DropTable(
                name: "RoomAmenities");

            migrationBuilder.DropTable(
                name: "PaymentBatches");

            migrationBuilder.DropTable(
                name: "RefundMethods");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "CountryStates");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
