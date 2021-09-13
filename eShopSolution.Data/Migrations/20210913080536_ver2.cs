using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e1396801-29e0-48ea-aabd-46f74a4a5fce");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c146928-e589-43ed-8a3c-6d68f050ad75", "AQAAAAEAACcQAAAAEGE+Z+fJq+sH9/js9eHF8Ml0DWnJqPm/8vVhTGHEjVPtRBxELPlsVwwBK5uUwzaJTQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 13, 15, 5, 35, 368, DateTimeKind.Local).AddTicks(1389));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d9d11253-04b3-4b6f-9623-251b7279851c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4dcc1e97-ca92-4ce3-906d-b3bd9a313c4e", "AQAAAAEAACcQAAAAEO6TyEruuDkv8vSSpbmoIiHJNHHrnKOy+GoQMxnw2xzS/5NNBu/xEZQbbulN4BifvQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 12, 14, 54, 7, 149, DateTimeKind.Local).AddTicks(9627));
        }
    }
}
