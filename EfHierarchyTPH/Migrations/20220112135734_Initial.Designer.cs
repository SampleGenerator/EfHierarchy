﻿// <auto-generated />
using System;
using EfHierarchyTPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfHierarchyTPH.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220112135734_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfHierarchy.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContractId"), 1L, 1);

                    b.Property<decimal>("Charge")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Months")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContractId");

                    b.ToTable("Contracts", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Contract");
                });

            modelBuilder.Entity("EfHierarchy.Models.BroadBandContract", b =>
                {
                    b.HasBaseType("EfHierarchy.Models.Contract");

                    b.Property<int>("DownloadSpeed")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("BroadBandContract");
                });

            modelBuilder.Entity("EfHierarchy.Models.MobileContract", b =>
                {
                    b.HasBaseType("EfHierarchy.Models.Contract");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MobileContract");
                });

            modelBuilder.Entity("EfHierarchy.Models.TvContract", b =>
                {
                    b.HasBaseType("EfHierarchy.Models.Contract");

                    b.Property<int>("PackageType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("TvContract");
                });
#pragma warning restore 612, 618
        }
    }
}
