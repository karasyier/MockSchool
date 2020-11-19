﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MockSchool.Web.DataRepositories;

namespace MockSchool.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201117154232_AddPhotoPathToStudent")]
    partial class AddPhotoPathToStudent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MockSchool.Web.DataRepositories.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Major")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhohtPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "cy85818@163.com",
                            Major = 1,
                            Name = "Karas"
                        },
                        new
                        {
                            Id = 2,
                            Email = "karasyier@hotmail.com",
                            Major = 3,
                            Name = "Karasyier"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
