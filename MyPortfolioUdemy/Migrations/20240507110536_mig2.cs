using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPortfolioUdemy.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    ToDoListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.ToDoListID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoLists");

        }
    }
}
