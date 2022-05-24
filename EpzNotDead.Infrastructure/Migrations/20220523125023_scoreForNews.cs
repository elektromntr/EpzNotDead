using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    public partial class scoreForNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("35b73593-2a52-4066-82f8-222a6d078957"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"));

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "ReferenceId", "Title", "Url" },
                values: new object[] { new Guid("f9a0e9d5-f55c-4fac-be6e-2e6108fee18f"), false, new DateTime(2022, 5, 23, 14, 50, 22, 776, DateTimeKind.Local).AddTicks(2386), null, new Guid("85439a0a-9ad9-430d-8f7a-d9eef7dea241"), "Facebook", "https://www.facebook.com/elektropunkz" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title" },
                values: new object[] { new Guid("85439a0a-9ad9-430d-8f7a-d9eef7dea241"), false, "Test content", new DateTime(2022, 5, 23, 14, 50, 22, 776, DateTimeKind.Local).AddTicks(2348), null, 0, "Short", "Test news" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("f9a0e9d5-f55c-4fac-be6e-2e6108fee18f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("85439a0a-9ad9-430d-8f7a-d9eef7dea241"));

            migrationBuilder.DropColumn(
                name: "Score",
                table: "News");

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "ReferenceId", "Title", "Url" },
                values: new object[] { new Guid("35b73593-2a52-4066-82f8-222a6d078957"), false, new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1055), null, new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"), "Facebook", "https://www.facebook.com/elektropunkz" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "ShortContent", "Title" },
                values: new object[] { new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"), false, "Test content", new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1016), null, "Short", "Test news" });
        }
    }
}
