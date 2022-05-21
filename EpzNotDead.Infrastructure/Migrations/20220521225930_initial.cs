using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "NewsId", "Title", "Url" },
                values: new object[] { new Guid("03d9a193-1357-484c-b000-7882549b4251"), false, new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(8030), new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(8033), null, "Telegram channel", "https://t.me/epznotdead" });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "NewsId", "Title", "Url" },
                values: new object[] { new Guid("f4aa9a40-8169-4b2e-b31f-16b1f0017a16"), false, new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(7945), new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(7981), null, "Facebook", "https://www.facebook.com/elektropunkz" });

            migrationBuilder.CreateIndex(
                name: "IX_Links_NewsId",
                table: "Links",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
