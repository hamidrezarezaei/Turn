﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nobatgir.Data;

namespace Nobatgir.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("13970830154839_category")]
    partial class category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nobatgir.Model.AdminMenu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Controller");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("AdminMenus");
                });

            modelBuilder.Entity("Nobatgir.Model.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Nobatgir.Model.CategorySetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategorySettings");
                });

            modelBuilder.Entity("Nobatgir.Model.CategoryTimeTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveDayCount");

                    b.Property<string>("ActiveTime");

                    b.Property<int>("CategoryID");

                    b.Property<int>("DeactiveDayCount");

                    b.Property<int>("DeactiveTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Times");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.Property<int>("WeekDay");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("CategoryTimeTemplates");
                });

            modelBuilder.Entity("Nobatgir.Model.Expert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int?>("SiteID");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExpertID");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("ExpertSettings");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertTimeTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveDayCount");

                    b.Property<string>("ActiveTime");

                    b.Property<int>("DeactiveDayCount");

                    b.Property<int>("DeactiveTime");

                    b.Property<int>("ExpertID");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Times");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.Property<int>("WeekDay");

                    b.HasKey("ID");

                    b.HasIndex("ExpertID");

                    b.ToTable("ExpertTimeTemplates");
                });

            modelBuilder.Entity("Nobatgir.Model.Site", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Domain");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key");

                    b.Property<int>("SiteID");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("Nobatgir.Model.SiteTimeTemplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveDayCount");

                    b.Property<string>("ActiveTime");

                    b.Property<int>("DeactiveDayCount");

                    b.Property<int>("DeactiveTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("OrderIndex");

                    b.Property<int>("SiteID");

                    b.Property<string>("Times");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateDateTime");

                    b.Property<int>("UserID");

                    b.Property<int>("WeekDay");

                    b.HasKey("ID");

                    b.HasIndex("SiteID");

                    b.ToTable("SiteTimeTemplates");
                });

            modelBuilder.Entity("Nobatgir.Model.CategorySetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Category", "Category")
                        .WithMany("CategorySettings")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.CategoryTimeTemplate", b =>
                {
                    b.HasOne("Nobatgir.Model.Category", "Category")
                        .WithMany("CategoryTimeTemplates")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.Expert", b =>
                {
                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID");
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertSetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany("ExpertSettings")
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.ExpertTimeTemplate", b =>
                {
                    b.HasOne("Nobatgir.Model.Expert", "Expert")
                        .WithMany("ExpertTimeTemplates")
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteSetting", b =>
                {
                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany("SiteSettings")
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nobatgir.Model.SiteTimeTemplate", b =>
                {
                    b.HasOne("Nobatgir.Model.Site", "Site")
                        .WithMany("SiteTimeTemplates")
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
