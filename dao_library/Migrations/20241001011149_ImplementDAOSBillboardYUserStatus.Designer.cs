﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dao_library;

#nullable disable

namespace daolibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001011149_ImplementDAOSBillboardYUserStatus")]
    partial class ImplementDAOSBillboardYUserStatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("entities_library.billboard.Billboard", b =>
                {
                    b.Property<long>("BillboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.HasKey("BillboardId");

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.ToTable("Billboards");
                });

            modelBuilder.Entity("entities_library.comment.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("PostId")
                        .HasColumnType("bigint");

                    b.Property<long>("ReportUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("UserBanId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("ReportUserId");

                    b.HasIndex("UserBanId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("entities_library.file_system.FileType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FileTypes");
                });

            modelBuilder.Entity("entities_library.file_system.Filee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("FileTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FileTypeId");

                    b.ToTable("Filees");
                });

            modelBuilder.Entity("entities_library.login.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("entities_library.login.UserBan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Reason")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("StartDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserBans");
                });

            modelBuilder.Entity("entities_library.post.Post", b =>
                {
                    b.Property<long>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("entities_library.reactions.Reaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("PostId")
                        .HasColumnType("bigint");

                    b.Property<int>("ReactionType")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("entities_library.report.Report", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReportStatus")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reports");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Report");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("entities_library.login.User", b =>
                {
                    b.HasBaseType("entities_library.login.Person");

                    b.Property<long?>("FileeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.HasIndex("FileeId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("entities_library.report.ReportUser", b =>
                {
                    b.HasBaseType("entities_library.report.Report");

                    b.Property<long>("ReportedUserId")
                        .HasColumnType("bigint");

                    b.HasIndex("ReportedUserId");

                    b.HasDiscriminator().HasValue("ReportUser");
                });

            modelBuilder.Entity("entities_library.billboard.Billboard", b =>
                {
                    b.HasOne("entities_library.post.Post", "Post")
                        .WithOne("Billboard")
                        .HasForeignKey("entities_library.billboard.Billboard", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("entities_library.comment.Comment", b =>
                {
                    b.HasOne("entities_library.post.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("entities_library.report.ReportUser", "ReportUser")
                        .WithMany()
                        .HasForeignKey("ReportUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("entities_library.login.UserBan", "UserBan")
                        .WithMany()
                        .HasForeignKey("UserBanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("entities_library.login.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportUser");

                    b.Navigation("User");

                    b.Navigation("UserBan");
                });

            modelBuilder.Entity("entities_library.file_system.Filee", b =>
                {
                    b.HasOne("entities_library.file_system.FileType", "FileType")
                        .WithMany()
                        .HasForeignKey("FileTypeId");

                    b.Navigation("FileType");
                });

            modelBuilder.Entity("entities_library.login.UserBan", b =>
                {
                    b.HasOne("entities_library.login.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("entities_library.post.Post", b =>
                {
                    b.HasOne("entities_library.login.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("entities_library.reactions.Reaction", b =>
                {
                    b.HasOne("entities_library.post.Post", null)
                        .WithMany("Ractions")
                        .HasForeignKey("PostId");

                    b.HasOne("entities_library.login.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("entities_library.report.Report", b =>
                {
                    b.HasOne("entities_library.login.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("entities_library.login.User", b =>
                {
                    b.HasOne("entities_library.file_system.Filee", "Filee")
                        .WithMany()
                        .HasForeignKey("FileeId");

                    b.Navigation("Filee");
                });

            modelBuilder.Entity("entities_library.report.ReportUser", b =>
                {
                    b.HasOne("entities_library.login.User", "ReportedUser")
                        .WithMany()
                        .HasForeignKey("ReportedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportedUser");
                });

            modelBuilder.Entity("entities_library.post.Post", b =>
                {
                    b.Navigation("Billboard")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("Ractions");
                });
#pragma warning restore 612, 618
        }
    }
}
