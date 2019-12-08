using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuveyService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suvey",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOFKids = table.Column<int>(nullable: false),
                    BookingEXperince = table.Column<int>(nullable: false),
                    SatisfactionWitHStaff = table.Column<int>(nullable: false),
                    SatisfactionWithFood = table.Column<int>(nullable: false),
                    SatisfactionWithCleaning = table.Column<int>(nullable: false),
                    OtherComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suvey", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suvey");
        }
    }
}
