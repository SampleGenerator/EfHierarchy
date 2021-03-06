// <auto-generated />
using System;
using EfHierarchyTPT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfHierarchyTPT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfHierarchyTPT.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("EfHierarchyTPT.Models.Student", b =>
                {
                    b.HasBaseType("EfHierarchyTPT.Models.Person");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EfHierarchyTPT.Models.Teacher", b =>
                {
                    b.HasBaseType("EfHierarchyTPT.Models.Person");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EfHierarchyTPT.Models.Student", b =>
                {
                    b.HasOne("EfHierarchyTPT.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("EfHierarchyTPT.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfHierarchyTPT.Models.Teacher", b =>
                {
                    b.HasOne("EfHierarchyTPT.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("EfHierarchyTPT.Models.Teacher", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
