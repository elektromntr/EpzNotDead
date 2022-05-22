using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    public partial class linksReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_News_NewsId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_NewsId",
                table: "Links");

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("03d9a193-1357-484c-b000-7882549b4251"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("f4aa9a40-8169-4b2e-b31f-16b1f0017a16"));

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Links");

            migrationBuilder.AddColumn<Guid>(
                name: "ReferenceId",
                table: "Links",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "ReferenceId", "Title", "Url" },
                values: new object[] { new Guid("35b73593-2a52-4066-82f8-222a6d078957"), false, new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1055), null, new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"), "Facebook", "https://www.facebook.com/elektropunkz" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "ShortContent", "Title" },
                values: new object[] { new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"), false, "Test content", new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1016), null, "Short", "Test news" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("35b73593-2a52-4066-82f8-222a6d078957"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"));

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "Links");

            migrationBuilder.AddColumn<Guid>(
                name: "NewsId",
                table: "Links",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Links_News_NewsId",
                table: "Links",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id");
        }
    }
}
