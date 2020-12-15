using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "OverUnder" },
                values: new object[] { 2, 1.0, 1.0, 1.0, 1.0, "Gamma Ray" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2);
        }
    }
}
