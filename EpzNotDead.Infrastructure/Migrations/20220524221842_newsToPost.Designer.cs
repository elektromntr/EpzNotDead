﻿// <auto-generated />
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
    [Migration("20220524221842_newsToPost")]
    partial class newsToPost
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
                            Id = new Guid("013810dd-9fd2-4091-b8b0-c1b7facbe868"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5572),
                            PostId = new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("ea6e7eae-fcd2-42b0-9cf9-46a3bd537e20"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5614),
                            PostId = new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("20f159a2-bb1f-4d55-b9df-847b8ee90c0f"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5771),
                            PostId = new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("bc363b38-0683-42e6-9657-4e6fc6b0aa2f"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5780),
                            PostId = new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("87095744-6a93-455b-8cb8-9270a06a9ca7"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5818),
                            PostId = new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("a5095e85-09b0-41fd-bc4b-ed998ced62ba"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5822),
                            PostId = new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("522720fb-e6de-4bbc-8311-ad11947cd3fc"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5979),
                            PostId = new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("4d18f67d-1b74-4e8e-a8c4-46ada5a3e06b"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5984),
                            PostId = new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
                        },
                        new
                        {
                            Id = new Guid("80b668be-b90e-4c9d-99cd-e79d08f28906"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6024),
                            PostId = new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("ea94dc7c-5445-44de-b85e-e36e4d353026"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6029),
                            PostId = new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"),
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
                            Id = new Guid("c639dbcd-ae93-4d98-9192-ce9798b98e0f"),
                            Archived = false,
                            Content = "Test content 0",
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5649),
                            Score = 0,
                            ShortContent = "Short 0",
                            Title = "Test news 0",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("c68aecb8-f402-443b-bd6d-a31e3392cb58"),
                            Archived = false,
                            Content = "Test content 1",
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5788),
                            Score = 0,
                            ShortContent = "Short 1",
                            Title = "Test news 1",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("34e2bc58-6817-4399-9dc0-8bd482247b6b"),
                            Archived = false,
                            Content = "Test content 2",
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5833),
                            Score = 0,
                            ShortContent = "Short 2",
                            Title = "Test news 2",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("50a8ce9d-7f05-45d6-837c-5ca65470fe1f"),
                            Archived = false,
                            Content = "Test content 3",
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(5992),
                            Score = 0,
                            ShortContent = "Short 3",
                            Title = "Test news 3",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("2e904cdc-6e0a-43e0-bc23-a51e7c9ac31b"),
                            Archived = false,
                            Content = "Test content 4",
                            Created = new DateTime(2022, 5, 25, 0, 18, 42, 22, DateTimeKind.Local).AddTicks(6036),
                            Score = 0,
                            ShortContent = "Short 4",
                            Title = "Test news 4",
                            Type = 0
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
