using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioCSharpRest.Migrations
{
    public partial class AddSyncUpdateAndSaveToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "IsSyncSave",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsSyncUpdate",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSyncSave",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSyncUpdate",
                table: "Products");
        }
    }
}
