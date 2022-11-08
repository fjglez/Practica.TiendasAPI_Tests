using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica.TiendasAPI.Migrations
{
    public partial class Arreglos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "PointsOfInterest");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointsOfInterest",
                type: "TEXT",
                maxLength: 300,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_ShopId",
                table: "PointsOfInterest",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_ShopId",
                table: "PointsOfInterest",
                column: "ShopId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_ShopId",
                table: "PointsOfInterest");

            migrationBuilder.DropIndex(
                name: "IX_PointsOfInterest_ShopId",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointsOfInterest");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "PointsOfInterest",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterest",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
