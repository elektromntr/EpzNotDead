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
    [Migration("20220521225930_initial")]
    partial class initial
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

                    b.Property<Guid?>("NewsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4aa9a40-8169-4b2e-b31f-16b1f0017a16"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(7945),
                            Edited = new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(7981),
                            Title = "Facebook",
                            Url = "https://www.facebook.com/elektropunkz"
                        },
                        new
                        {
                            Id = new Guid("03d9a193-1357-484c-b000-7882549b4251"),
                            Archived = false,
                            Created = new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(8030),
                            Edited = new DateTime(2022, 5, 22, 0, 59, 30, 632, DateTimeKind.Local).AddTicks(8033),
                            Title = "Telegram channel",
                            Url = "https://t.me/epznotdead"
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
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.Link", b =>
                {
                    b.HasOne("EpzNotDead.Infrastructure.Entities.News", null)
                        .WithMany("Links")
                        .HasForeignKey("NewsId");
                });

            modelBuilder.Entity("EpzNotDead.Infrastructure.Entities.News", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
