using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClinic.MVC.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Born",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "DateBirth",
                table: "Clients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBirth",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "Born",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
