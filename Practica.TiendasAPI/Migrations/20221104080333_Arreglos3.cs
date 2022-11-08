using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica.TiendasAPI.Migrations
{
    public partial class Arreglos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_ShopId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Tiendas");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_ShopId",
                table: "Productos",
                newName: "IX_Productos_ShopId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Tiendas_ShopId",
                table: "Productos",
                column: "ShopId",
                principalTable: "Tiendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Tiendas_ShopId",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Tiendas",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "PointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_ShopId",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_ShopId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_ShopId",
                table: "PointsOfInterest",
                column: "ShopId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
