using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClinic.MVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CPF = table.Column<string>(maxLength: 11, nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    Born = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
