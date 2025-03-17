using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class mg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "RemainingItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "IsActive", "Name", "NormalizedName", "UpdatedDate" },
                values: new object[,]
                {
                    { "115c7796-cfac-44de-91b5-916eaae125b5", null, new DateTime(2025, 3, 16, 1, 5, 17, 520, DateTimeKind.Local).AddTicks(7173), "Administrator role", true, "AdminUser", "ADMINUSER", null },
                    { "811f466c-9d06-43f8-a054-24aedbb4161b", null, new DateTime(2025, 3, 16, 1, 5, 17, 520, DateTimeKind.Local).AddTicks(7241), "Regular user role", true, "NormalUser", "NORMALUSER", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14a0183f-1e96-4930-a83d-6ef5f22d8c09", 0, "431a5449-8933-49d8-ba08-2182bf65c673", "normaluser@gmail.com", true, "Admin2", "User", false, null, "admin@GMAIL.COM", "admin@GMAIL.COM", "AQAAAAIAAYagAAAAEM27L65A3uY50ijgvpSxC9L4l2qyNBtPIamoTsqNyr9ItqN8ime2Z3sC/BzgxJM6Xw==", null, false, "dec6a618-4bfc-43de-b940-04be3aa94082", false, "normaluser@gmail.com" },
                    { "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac", 0, "a9360786-edcb-4b38-b42a-2db66affca0b", "adminuser@gmail.com", true, "Admin", "User", false, null, "ADMINUSER@GMAIL.COM", "mehmet@GMAIL.COM", "AQAAAAIAAYagAAAAELsR4mqTEcjAL+gPVLHpMhfgCSRfkg4EIIB/iY/OTL97VvCJrIbTowQjAo2N0w4Bxg==", "5255", false, "78b7f6ff-b681-429e-8241-059593546e26", false, "mehmet@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "İstanbul", new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(773), "ali@example.com", "Ali Yılmaz", "555-111-2233" },
                    { 2, "Ankara", new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(797), "mehmet@example.com", "Mehmet Demir", "555-222-3344" },
                    { 3, "İzmir", new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(798), "ayse@example.com", "Ayşe Çelik", "555-333-4455" },
                    { 4, "Bursa", new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(799), "zeynep@example.com", "Zeynep Korkmaz", "555-444-5566" },
                    { 5, "Antalya", new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(800), "mustafa@example.com", "Mustafa Kaya", "555-555-6677" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "HireDate", "IsActive", "Phone", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "ahmet@example.com", "Ahmet Karaca", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "544-123-4567", "Satış Temsilcisi", 15000m },
                    { 2, "elif@example.com", "Elif Yıldız", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "544-234-5678", "Muhasebe", 18000m },
                    { 3, "caner@example.com", "Caner Doğan", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "544-345-6789", "Depo Sorumlusu", 17000m },
                    { 4, "gizem@example.com", "Gizem Arslan", new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "544-456-7890", "Müşteri Temsilcisi", 16000m },
                    { 5, "murat@example.com", "Murat Şahin", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "544-567-8901", "Teknik Destek", 14000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "SquareMeters", "UnitRentalPrice" },
                values: new object[,]
                {
                    { 1, "Dayanıklı ve şık ahşap masa", "Ahşap Masa", 4500m, 2.5, 200m },
                    { 2, "Dayanıklı metal sandalye", "Metal Sandalye", 1200m, 1.2, 100m },
                    { 3, "Konforlu ve geniş koltuk takımı", "Koltuk Takımı", 15000m, 5.0, 500m },
                    { 4, "Modern laminant parke döşeme", "Laminant Parke", 3500m, 20.0, 150m },
                    { 5, "Yüksek çözünürlüklü projektör", "Projektör", 5000m, 0.5, 250m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "811f466c-9d06-43f8-a054-24aedbb4161b", "14a0183f-1e96-4930-a83d-6ef5f22d8c09" },
                    { "115c7796-cfac-44de-91b5-916eaae125b5", "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "811f466c-9d06-43f8-a054-24aedbb4161b", "14a0183f-1e96-4930-a83d-6ef5f22d8c09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "115c7796-cfac-44de-91b5-916eaae125b5", "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "RemainingItems");
        }
    }
}
