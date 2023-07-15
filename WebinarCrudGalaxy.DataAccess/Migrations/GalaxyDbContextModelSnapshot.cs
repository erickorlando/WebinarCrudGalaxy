﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebinarCrudGalaxy.DataAccess;

#nullable disable

namespace WebinarCrudGalaxy.DataAccess.Migrations
{
    [DbContext(typeof(GalaxyDbContext))]
    partial class GalaxyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebinarCrudGalaxy.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Velasco",
                            Email = "erick@gmail.com",
                            Nombres = "Erick"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Velasco",
                            Email = "adam@gmail.com",
                            Nombres = "Adam"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Velasco",
                            Email = "patrick@gmail.com",
                            Nombres = "Patrick"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}