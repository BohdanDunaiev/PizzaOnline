using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOnline2.DAL.Migrations
{
    public partial class None : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizza_PizzaId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzeria_PizzeriaId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "Delivery");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PizzeriaId",
                table: "Order",
                newName: "IX_Order_PizzeriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PizzaId",
                table: "Order",
                newName: "IX_Order_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeliveryId",
                table: "Order",
                newName: "IX_Order_DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Delivery_DeliveryId",
                table: "Order",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pizza_PizzaId",
                table: "Order",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Pizzeria_PizzeriaId",
                table: "Order",
                column: "PizzeriaId",
                principalTable: "Pizzeria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Delivery_DeliveryId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pizza_PizzaId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Pizzeria_PizzeriaId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Delivery",
                newName: "Deliveries");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PizzeriaId",
                table: "Orders",
                newName: "IX_Orders_PizzeriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PizzaId",
                table: "Orders",
                newName: "IX_Orders_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DeliveryId",
                table: "Orders",
                newName: "IX_Orders_DeliveryId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizza_PizzaId",
                table: "Orders",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzeria_PizzeriaId",
                table: "Orders",
                column: "PizzeriaId",
                principalTable: "Pizzeria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
