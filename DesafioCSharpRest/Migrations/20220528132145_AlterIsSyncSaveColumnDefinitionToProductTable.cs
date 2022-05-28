using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioCSharpRest.Migrations
{
    public partial class AlterIsSyncSaveColumnDefinitionToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsSyncSave",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "IsSyncSave",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
