using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganizeYourGames.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    PublishedIn = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BBGLink = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    NumberOfOrganizers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Inserts",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Game = table.Column<string>(nullable: true),
                    Store = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    LinkToBuy = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inserts", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Inserts");
        }
    }
}
