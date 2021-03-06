// <auto-generated />
using System;
using EpzNotDead.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EpzNotDead.Infrastructure.Migrations
{
    [DbContext(typeof(EpzNotDeadContext))]
    [Migration("20220524222913_postsWithAdditionalContent")]
    partial class postsWithAdditionalContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.AdditionalContent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("AdditionalContent");

                    b.HasData(
                        new
                        {
                            Id = new Guid("73df8cc0-91a3-498b-af4c-76647a3c518d"),
                            Content = "Test additional content 1",
                            Name = 2,
                            PostId = new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a")
                        },
                        new
                        {
                            Id = new Guid("7395ccbf-ba9e-4be9-b1f0-717cb20d3cde"),
                            Content = "Test additional content 2",
                            Name = 2,
                            PostId = new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00")
                        },
                        new
                        {
                            Id = new Guid("6eb1209d-fdeb-4c5b-9a05-18e04ae33b87"),
                            Content = "Test additional content 3",
                            Name = 2,
                            PostId = new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0")
                        });
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.Link", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0abefb78-8e8a-4dcd-8f93-f5ce73095f97"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(4996),
                            PostId = new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("9dcd7892-6cb3-4753-b8ca-e883245423c4"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5048),
                            PostId = new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("d281687c-d2d3-4ed8-afb6-5c1dd44cba48"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5358),
                            PostId = new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("856d1b5e-38d2-434a-b875-2a200634dc6c"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5370),
                            PostId = new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("e19af1a8-110b-4d5d-b458-c85fae273174"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5423),
                            PostId = new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("0a176f8c-152c-4ca4-ad95-c767956d93f2"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5429),
                            PostId = new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        });
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Edited")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("ShortContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("048d25b3-c6b8-45d1-bcad-e5f2301a5a1a"),
                            Archived = false,
                            Content = "Test content 1",
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5216),
                            Score = 0,
                            ShortContent = "Short 1",
                            Title = "Test news 1",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("6f631f1f-c563-4c0e-8504-7ba0afa87d00"),
                            Archived = false,
                            Content = "Test content 2",
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5381),
                            Score = 0,
                            ShortContent = "Short 2",
                            Title = "Test news 2",
                            Type = 2
                        },
                        new
                        {
                            Id = new Guid("05428779-4814-4ebe-b217-1e4c7f4d7ff0"),
                            Archived = false,
                            Content = "Test content 3",
                            Created = new DateTime(2022, 5, 25, 0, 29, 13, 246, DateTimeKind.Local).AddTicks(5442),
                            Score = 0,
                            ShortContent = "Short 3",
                            Title = "Test news 3",
                            Type = 3
                        });
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.AdditionalContent", b =>
                {
                    b.HasOne("EpzNotDead.Infrastructure.Entities.Post", "Post")
                        .WithMany("AdditionalContent")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.Link", b =>
                {
                    b.HasOne("EpzNotDead.Infrastructure.Entities.Post", "Post")
                        .WithMany("Links")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.Post", b =>
                {
                    b.Navigation("AdditionalContent");

                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
