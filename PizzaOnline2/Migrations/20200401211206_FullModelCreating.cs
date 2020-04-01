using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOnline2.Migrations
{
    public partial class FullModelCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePizza = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizzeria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePizzeria = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzeria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaId = table.Column<int>(nullable: false),
                    Cheese = table.Column<string>(nullable: true),
                    Tomate = table.Column<string>(nullable: true),
                    Sausege = table.Column<string>(nullable: true),
                    Sous = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaId",
                table: "Orders",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzeriaId",
                table: "Orders",
                column: "PizzeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaId",
                table: "Ingredients",
                column: "PizzaId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizza_PizzaId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzeria_PizzeriaId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Pizzeria");

            migrationBuilder.DropTable(
                name: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PizzaId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PizzeriaId",
                table: "Orders");
        }
    }
}
