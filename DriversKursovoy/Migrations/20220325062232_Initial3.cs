using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriversKursovoy.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PathNumbers",
                columns: table => new
                {
                    Number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PathSequence = table.Column<string>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathNumbers", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PathNumbers");
        }
    }
}
