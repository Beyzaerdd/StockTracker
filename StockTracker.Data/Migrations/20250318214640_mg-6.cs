using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class mg6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DailyPrice",
                table: "RemainingProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "RemainingProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 19, 0, 46, 40, 571, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 19, 0, 46, 40, 571, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1872c4cf-ea91-4572-9e00-9a9553766e23", "AQAAAAIAAYagAAAAENOwbWtYO8fmuI1EacA1YCL8oRcTtg9+C18bMeHfCGYULYcvFX8xE+fXe3NpH3vn9Q==", "afd777f8-7ed2-4259-b6ee-7a5c0f491b5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ce322be-348e-43f7-a4e1-9da502ca1000", "AQAAAAIAAYagAAAAEPtXHVWOzojN3e9Z+XB7Te8HoZWFXjlj7BJ9ENpo8SjwQ07oPFVhE9YCyA0KqlJmHA==", "aae59e4e-9322-4252-9d18-563350c70607" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyPrice",
                table: "RemainingProducts");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "RemainingProducts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 23, 0, 55, 636, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 18, 23, 0, 55, 636, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6ce054-3355-490d-98e5-b6052facde58", "AQAAAAIAAYagAAAAEGD8R4OFgXW5BAE77yK04nUa3UAonoZew91k1vlNVZOMRrRkWyEzivAfBKu4WBj2Kw==", "322edf68-9500-42cf-bfa3-3bf6abe9df40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ebfa94d-5218-41e5-aead-9cc06f38bc5b", "AQAAAAIAAYagAAAAEBxpAMwImWM8PdXMk7fl6sY/u/zEqzVcwd5y4c2H2RqjEMbYTiagXYYK2C6SXy6Qvw==", "6baae86d-6d14-4a6e-92e2-8aa98be1a975" });
        }
    }
}
