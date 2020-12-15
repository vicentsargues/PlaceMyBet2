using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MercadoId",
                table: "Apuestas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Apuestas_MercadoId",
                table: "Apuestas",
                column: "MercadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apuestas_Mercados_MercadoId",
                table: "Apuestas",
                column: "MercadoId",
                principalTable: "Mercados",
                principalColumn: "MercadoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apuestas_Mercados_MercadoId",
                table: "Apuestas");

            migrationBuilder.DropIndex(
                name: "IX_Apuestas_MercadoId",
                table: "Apuestas");

            migrationBuilder.DropColumn(
                name: "MercadoId",
                table: "Apuestas");
        }
    }
}
