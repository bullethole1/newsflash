﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NewsFlash_edited.Models.services;
using System;

namespace NewsFlash_edited.Models.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    [Migration("20171012135831_secondTagServiceMigration")]
    partial class secondTagServiceMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsFlash_edited.Models.models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Header");

                    b.Property<string>("Img");

                    b.Property<string>("Link");

                    b.Property<DateTime?>("Publishdate");

                    b.Property<string>("Source");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("NewsFlash_edited.Models.models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });
#pragma warning restore 612, 618
        }
    }
}