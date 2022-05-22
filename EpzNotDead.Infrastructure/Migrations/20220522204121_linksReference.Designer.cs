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
    [Migration("20220522204121_linksReference")]
    partial class linksReference
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<Guid>("ReferenceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35b73593-2a52-4066-82f8-222a6d078957"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1055),
                            ReferenceId = new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        });
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.News", b =>
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

                    b.Property<string>("ShortContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d91466cb-3f67-40e6-9da1-7c12d74aac7e"),
                            Archived = false,
                            Content = "Test content",
                            Created = new DateTime(2022, 5, 22, 22, 41, 20, 791, DateTimeKind.Local).AddTicks(1016),
                            ShortContent = "Short",
                            Title = "Test news"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}