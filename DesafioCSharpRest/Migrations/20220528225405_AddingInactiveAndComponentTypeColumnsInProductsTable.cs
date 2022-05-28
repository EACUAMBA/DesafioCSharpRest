using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioCSharpRest.Migrations
{
    public partial class AddingInactiveAndComponentTypeColumnsInProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "Products");
        }
    }
}
