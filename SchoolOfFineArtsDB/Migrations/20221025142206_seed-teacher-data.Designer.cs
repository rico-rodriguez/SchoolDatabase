﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolOfFineArtsDB;

#nullable disable

namespace SchoolOfFineArtsDB.Migrations
{
    [DbContext(typeof(SchoolOfFineArtsDBContext))]
    [Migration("20221025142206_seed-teacher-data")]
    partial class seedteacherdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolOfFineArtsModels.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 27,
                            FirstName = "Anne",
                            LastName = "Sullivan"
                        },
                        new
                        {
                            Id = 2,
                            Age = 32,
                            FirstName = "Maria",
                            LastName = "Montessori"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            FirstName = "William",
                            LastName = "McGuffey"
                        },
                        new
                        {
                            Id = 4,
                            Age = 47,
                            FirstName = "Emma",
                            LastName = "Willard"
                        },
                        new
                        {
                            Id = 5,
                            Age = 62,
                            FirstName = "Jaime",
                            LastName = "Escalante"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
