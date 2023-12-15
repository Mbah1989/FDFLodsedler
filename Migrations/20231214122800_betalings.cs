using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDFLodsedler.Migrations
{
    public partial class betalings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Børn_Id",
                table: "Betalings",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Børn_Id",
                table: "Betalings");
        }
    }
}
