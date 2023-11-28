﻿// <auto-generated />
using System;
using Carwash.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carwash.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231122070458_addcars")]
    partial class addcars
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Carwash.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pride"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dena"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Arrizo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Persia"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Peugeot405"
                        },
                        new
                        {
                            Id = 6,
                            Name = "SurenPlus"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Samand"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Runu"
                        },
                        new
                        {
                            Id = 9,
                            Name = "206"
                        },
                        new
                        {
                            Id = 10,
                            Name = "207"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Tara"
                        },
                        new
                        {
                            Id = 12,
                            Name = "SLX"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Shahin"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Optima"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Azera"
                        });
                });

            modelBuilder.Entity("Carwash.Domain.Entities.Khadamat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Khadamats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Roshoee",
                            Price = 60000m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Broom",
                            Price = 40000m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wax",
                            Price = 50000m
                        });
                });

            modelBuilder.Entity("Carwash.Domain.Entities.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mousavi@gmail.com",
                            FirstName = "mahdi",
                            LastName = "mousavi",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("Carwash.Domain.Entities.Worker", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Bonus = 0,
                            FirstName = "mahdi",
                            LastName = "mousavi",
                            Salary = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 55,
                            Bonus = 0,
                            FirstName = "emaeil",
                            LastName = "akbary",
                            Salary = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 17,
                            Bonus = 0,
                            FirstName = "amirhosein",
                            LastName = "Khodabandelo",
                            Salary = 0
                        });
                });

            modelBuilder.Entity("Carwash.Domain.Entities.WorkerInKhadamat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KhadamatId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KhadamatId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerInKhadamat");
                });

            modelBuilder.Entity("Carwash.Domain.Entities.WorkerInKhadamat", b =>
                {
                    b.HasOne("Carwash.Domain.Entities.Khadamat", "Khadamat")
                        .WithMany("WorkerInKhadamats")
                        .HasForeignKey("KhadamatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carwash.Domain.Entities.Worker", "Worker")
                        .WithMany("WorkerInKhadamats")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khadamat");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Carwash.Domain.Entities.Khadamat", b =>
                {
                    b.Navigation("WorkerInKhadamats");
                });

            modelBuilder.Entity("Carwash.Domain.Entities.Worker", b =>
                {
                    b.Navigation("WorkerInKhadamats");
                });
#pragma warning restore 612, 618
        }
    }
}
