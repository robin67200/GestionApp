using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionApp.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameProject = table.Column<string>(nullable: true),
                    Users = table.Column<string>(nullable: true),
                    TimeSpent = table.Column<decimal>(nullable: false),
                    PriceProject = table.Column<int>(nullable: false),
                    Client = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
