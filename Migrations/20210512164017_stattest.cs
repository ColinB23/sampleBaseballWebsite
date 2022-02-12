using Microsoft.EntityFrameworkCore.Migrations;

namespace BrodnikProject.Migrations
{
    public partial class stattest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hits = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false),
                    BA = table.Column<int>(nullable: false),
                    SO = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stat");
        }
    }
}
