using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    public partial class newsToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("f9a0e9d5-f55c-4fac-be6e-2e6108fee18f"));

            migrationBuilder.RenameColumn(
                name: "ReferenceId",
                table: "Links",
                newName: "PostId");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archived = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalContent_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"), false, "Test content 4", new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6036), null, 0, "Short 4", "Test news 4", 0 },
                    { new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"), false, "Test content 2", new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5833), null, 0, "Short 2", "Test news 2", 0 },
                    { new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"), false, "Test content 3", new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5992), null, 0, "Short 3", "Test news 3", 0 },
                    { new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"), false, "Test content 0", new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5649), null, 0, "Short 0", "Test news 0", 0 },
                    { new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"), false, "Test content 1", new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5788), null, 0, "Short 1", "Test news 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "PostId", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("013810dd-9fd2-4091-b8b0-c1b7facbe868"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5572), null, new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("20f159a2-bb1f-4d55-b9df-847b8ee90c0f"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5771), null, new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("4d18f67d-1b74-4e8e-a8c4-46ada5a3e06b"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5984), null, new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("522720fb-e6de-4bbc-8311-ad11947cd3fc"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5979), null, new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("80b668be-b90e-4c9d-99cd-e79d08f28906"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6024), null, new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("87095744-6a93-455b-8cb8-9270a06a9ca7"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5818), null, new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("a5095e85-09b0-41fd-bc4b-ed998ced62ba"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5822), null, new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("bc363b38-0683-42e6-9657-4e6fc6b0aa2f"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5780), null, new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("ea6e7eae-fcd2-42b0-9cf9-46a3bd537e20"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5614), null, new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("ea94dc7c-5445-44de-b85e-e36e4d353026"), false, new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6029), null, new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"), "Telegram channel", "https://t.me/epznotdead" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_PostId",
                table: "Links",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalContent_PostId",
                table: "AdditionalContent",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Posts_PostId",
                table: "Links",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_Posts_PostId",
                table: "Links");

            migrationBuilder.DropTable(
                name: "AdditionalContent");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Links_PostId",
                table: "Links");

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("013810dd-9fd2-4091-b8b0-c1b7facbe868"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("20f159a2-bb1f-4d55-b9df-847b8ee90c0f"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("4d18f67d-1b74-4e8e-a8c4-46ada5a3e06b"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("522720fb-e6de-4bbc-8311-ad11947cd3fc"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("80b668be-b90e-4c9d-99cd-e79d08f28906"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("87095744-6a93-455b-8cb8-9270a06a9ca7"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("a5095e85-09b0-41fd-bc4b-ed998ced62ba"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("bc363b38-0683-42e6-9657-4e6fc6b0aa2f"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("ea6e7eae-fcd2-42b0-9cf9-46a3bd537e20"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("ea94dc7c-5445-44de-b85e-e36e4d353026"));

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Links",
                newName: "ReferenceId");

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Archived = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edited = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "ReferenceId", "Title", "Url" },
                values: new object[] { new Guid("f9a0e9d5-f55c-4fac-be6e-2e6108fee18f"), false, new DateTime(2022, 5, 23, 14, 50, 22, 776, DateTimeKind.Local).AddTicks(2386), null, new Guid("85439a0a-9ad9-430d-8f7a-d9eef7dea241"), "Facebook", "https://www.facebook.com/elektropunkz" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title" },
                values: new object[] { new Guid("85439a0a-9ad9-430d-8f7a-d9eef7dea241"), false, "Test content", new DateTime(2022, 5, 23, 14, 50, 22, 776, DateTimeKind.Local).AddTicks(2348), null, 0, "Short", "Test news" });
        }
    }
}
