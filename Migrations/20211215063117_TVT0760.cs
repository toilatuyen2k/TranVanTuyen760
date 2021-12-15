using Microsoft.EntityFrameworkCore.Migrations;

namespace TranVanTuyen760.Migrations
{
    public partial class TVT0760 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVT0760",
                columns: table => new
                {
                    TVTId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TVTName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TVTGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVT0760", x => x.TVTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TVT0760");
        }
    }
}
