using Microsoft.EntityFrameworkCore.Migrations;

namespace Music.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Composers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    ComposerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Composers_ComposerId",
                        column: x => x.ComposerId,
                        principalTable: "Composers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Composers",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 1, "Hans Zimmer", "8823923232" });

            migrationBuilder.InsertData(
                table: "Composers",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[] { 2, "Ilayaraja", "8923232323" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ComposerId", "Genre", "Name" },
                values: new object[] { 1, 1, "Soundtrack", "Spiderman" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ComposerId", "Genre", "Name" },
                values: new object[] { 2, 2, "Instrumental", "How to name it" });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ComposerId",
                table: "Albums",
                column: "ComposerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Composers");
        }
    }
}
