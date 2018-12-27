using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanyPieShop.Migrations
{
    public partial class ModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsinStock",
                table: "Pies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsinStock",
                table: "Pies");
        }
    }
}
