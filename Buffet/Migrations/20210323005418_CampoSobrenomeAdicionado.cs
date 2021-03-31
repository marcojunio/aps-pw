using Microsoft.EntityFrameworkCore.Migrations;

namespace Buffet.Migrations
{
    public partial class CampoSobrenomeAdicionado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Clientes");
        }
    }
}
