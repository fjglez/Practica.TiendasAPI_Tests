using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica.TiendasAPI.Migrations
{
    public partial class Repopular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pan integral");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "ShopId" },
                values: new object[] { "Porción de bizcocho casero.", "Bizcocho", 0.29999999999999999, 1 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Description", "Name", "Price", "ShopId" },
                values: new object[] { 3, "Botella de 1 litro de cerveza.", "Cruzcampo 1L", 1.0, 2 });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Description", "Name", "Price", "ShopId" },
                values: new object[] { 4, "Botella de 1 litro de agua.", "Agua 2L", 1.0, 2 });

            migrationBuilder.InsertData(
                table: "Tiendas",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, null, "Supermercados MAS" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Description", "Name", "Price", "ShopId" },
                values: new object[] { 5, "Botella de 1 litro de agua.", "Agua 2L", 1.2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tiendas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pan");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "ShopId" },
                values: new object[] { "Botella de 1 litro de cerveza.", "Cruzcampo 1L", 1.0, 2 });
        }
    }
}
