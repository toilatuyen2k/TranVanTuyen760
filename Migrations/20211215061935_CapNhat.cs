using Microsoft.EntityFrameworkCore.Migrations;

namespace TranVanTuyen760.Migrations
{
    public partial class CapNhat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityTVT760",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityTVT760", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityTVT760");
        }
    }
}
