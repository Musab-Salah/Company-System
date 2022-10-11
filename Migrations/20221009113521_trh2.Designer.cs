﻿// <auto-generated />
using System;
using CompanySystem.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanySystem.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20221009113521_trh2")]
    partial class trh2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanySystem.DAL.PageSectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PageSection");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Musab",
                            CreatedOn = new DateTime(2022, 10, 9, 14, 35, 21, 177, DateTimeKind.Local).AddTicks(6239),
                            Description = "First Description",
                            IsDeleted = false,
                            ModifiedBy = "SALAH",
                            ModifiedOn = new DateTime(2022, 10, 9, 14, 35, 21, 177, DateTimeKind.Local).AddTicks(6275),
                            OrderNumber = 0,
                            Title = "Musab"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Musab",
                            CreatedOn = new DateTime(2022, 10, 9, 14, 35, 21, 177, DateTimeKind.Local).AddTicks(6280),
                            Description = "First Description",
                            IsDeleted = true,
                            ModifiedBy = "SALAH",
                            ModifiedOn = new DateTime(2022, 10, 9, 14, 35, 21, 177, DateTimeKind.Local).AddTicks(6282),
                            OrderNumber = 0,
                            Title = "test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}