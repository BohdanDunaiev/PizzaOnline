using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOnline2.Migrations
{
    public partial class Delivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "time",
                table: "Deliveries",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Deliveries",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "nameDelivery",
                table: "Deliveries",
                newName: "NameDelivery");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Deliveries",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Deliveries",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Deliveries",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "NameDelivery",
                table: "Deliveries",
                newName: "nameDelivery");

            migrationBuilder.AlterColumn<DateTime>(
                name: "time",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
