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
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 452, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 452, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6231bb57-6b7a-46da-aa39-17f1eb839350", "AQAAAAIAAYagAAAAEJ8+9LezALUCIl55Gyj4tKcjWIRHkMSyOlktygbgu+GwVNhvC4l39uzUk+01WgSA+w==", "7d00b301-05d8-48ec-9a30-b9f71b217d97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdec0ef2-6441-4167-bf6f-1ae908fb3c80", "AQAAAAIAAYagAAAAEJolPhVs6sLx3e9xc/5g/TUU5GVXAgOzN9NXYbUZ9sWKLgHZLP0VvYY4ZhSLCtQW+A==", "f4921599-ad1d-4662-9b9d-8072e16acc47" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 614, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 614, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 614, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 614, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 17, 20, 50, 42, 614, DateTimeKind.Local).AddTicks(4572));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 255, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 255, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9fb2df4-0fb6-40c0-9a54-34c64fd913b8", "AQAAAAIAAYagAAAAEEtHcKuszPq5g74U5Vv/pTVwgfm5XLnFVJjR4VGOyI36Rq9aEBVD3bzbTu+hCgP9Wg==", "54a6380b-c34a-410c-8575-eecc86a97158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec3c4b1d-895c-4d6f-b064-e6c297b65d41", "AQAAAAIAAYagAAAAEHqPOQMLvb65/2OezPsiUSvVy/mpom3WYzjjNn5FQlrmEwimHyIq1KFtx1qQkgBcfw==", "c226bf51-9bb7-4080-8d95-ef93b39a50af" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 324, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 324, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 324, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 324, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 20, 23, 324, DateTimeKind.Local).AddTicks(7388));
        }
    }
}
