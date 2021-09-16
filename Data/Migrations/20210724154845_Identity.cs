using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DutchThreat.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 7, 24, 15, 48, 45, 646, DateTimeKind.Utc).AddTicks(2099));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 7, 16, 13, 40, 47, 599, DateTimeKind.Utc).AddTicks(6760));
        }
    }
}
