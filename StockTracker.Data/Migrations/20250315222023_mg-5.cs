using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class mg5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "DeliveredItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "DeliveredItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "115c7796-cfac-44de-91b5-916eaae125b5",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 520, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "811f466c-9d06-43f8-a054-24aedbb4161b",
                column: "CreatedDate",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 520, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "431a5449-8933-49d8-ba08-2182bf65c673", "AQAAAAIAAYagAAAAEM27L65A3uY50ijgvpSxC9L4l2qyNBtPIamoTsqNyr9ItqN8ime2Z3sC/BzgxJM6Xw==", "dec6a618-4bfc-43de-b940-04be3aa94082" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9360786-edcb-4b38-b42a-2db66affca0b", "AQAAAAIAAYagAAAAELsR4mqTEcjAL+gPVLHpMhfgCSRfkg4EIIB/iY/OTL97VvCJrIbTowQjAo2N0w4Bxg==", "78b7f6ff-b681-429e-8241-059593546e26" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 16, 1, 5, 17, 592, DateTimeKind.Local).AddTicks(800));
        }
    }
}
