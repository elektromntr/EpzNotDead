using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    public partial class postsWithAdditionalContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title", "Type" },
                values: new object[] { new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"), false, "Test content 1", new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5216), null, 0, "Short 1", "Test news 1", 1 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title", "Type" },
                values: new object[] { new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"), false, "Test content 3", new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5442), null, 0, "Short 3", "Test news 3", 3 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Archived", "Content", "Created", "Edited", "Score", "ShortContent", "Title", "Type" },
                values: new object[] { new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"), false, "Test content 2", new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5381), null, 0, "Short 2", "Test news 2", 2 });

            migrationBuilder.InsertData(
                table: "AdditionalContent",
                columns: new[] { "Id", "Content", "Name", "PostId" },
                values: new object[,]
                {
                    { new Guid("6eb1209d-fdeb-4c5b-9a05-18e04ae33b87"), "Test additional content 3", 2, new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0") },
                    { new Guid("7395ccbf-ba9e-4be9-b1f0-717cb20d3cde"), "Test additional content 2", 2, new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00") },
                    { new Guid("73df8cc0-91a3-498b-af4c-76647a3c518d"), "Test additional content 1", 2, new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a") }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Archived", "Created", "Edited", "PostId", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("0a176f8c-152c-4ca4-ad95-c767956d93f2"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5429), null, new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("0abefb78-8e8a-4dcd-8f93-f5ce73095f97"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(4996), null, new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("856d1b5e-38d2-434a-b875-2a200634dc6c"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5370), null, new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("9dcd7892-6cb3-4753-b8ca-e883245423c4"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5048), null, new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"), "Telegram channel", "https://t.me/epznotdead" },
                    { new Guid("d281687c-d2d3-4ed8-afb6-5c1dd44cba48"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5358), null, new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"), "Facebook", "https://www.facebook.com/elektropunkz" },
                    { new Guid("e19af1a8-110b-4d5d-b458-c85fae273174"), false, new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5423), null, new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"), "Facebook", "https://www.facebook.com/elektropunkz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdditionalContent",
                keyColumn: "Id",
                keyValue: new Guid("6eb1209d-fdeb-4c5b-9a05-18e04ae33b87"));

            migrationBuilder.DeleteData(
                table: "AdditionalContent",
                keyColumn: "Id",
                keyValue: new Guid("7395ccbf-ba9e-4be9-b1f0-717cb20d3cde"));

            migrationBuilder.DeleteData(
                table: "AdditionalContent",
                keyColumn: "Id",
                keyValue: new Guid("73df8cc0-91a3-498b-af4c-76647a3c518d"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("0a176f8c-152c-4ca4-ad95-c767956d93f2"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("0abefb78-8e8a-4dcd-8f93-f5ce73095f97"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("856d1b5e-38d2-434a-b875-2a200634dc6c"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("9dcd7892-6cb3-4753-b8ca-e883245423c4"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("d281687c-d2d3-4ed8-afb6-5c1dd44cba48"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("e19af1a8-110b-4d5d-b458-c85fae273174"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"));

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
        }
    }
}
