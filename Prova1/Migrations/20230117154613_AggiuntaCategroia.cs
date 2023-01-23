using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MypizzeriaModel.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaCategroia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CategoriaId",
                table: "Pizzas",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Categoria_CategoriaId",
                table: "Pizzas",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Categoria_CategoriaId",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CategoriaId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Pizzas");
        }
    }
}
