using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica.TiendasAPI.Migrations
{
    public partial class Arreglos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Botella de 1 litro de cerveza.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: null);
        }
    }
}
