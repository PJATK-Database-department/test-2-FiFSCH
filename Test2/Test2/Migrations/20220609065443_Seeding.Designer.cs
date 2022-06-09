﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test2.Models;

namespace Test2.Migrations
{
    [DbContext(typeof(S22455Context))]
    [Migration("20220609065443_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Test2.Models.Car", b =>
                {
                    b.Property<int>("IdCar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int");

                    b.HasKey("IdCar");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Test2.Models.Inspection", b =>
                {
                    b.Property<int>("IdInspection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("IdCar")
                        .HasColumnType("int");

                    b.Property<int>("IdMechanic")
                        .HasColumnType("int");

                    b.Property<DateTime>("InspectionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdInspection");

                    b.HasIndex("IdCar");

                    b.HasIndex("IdMechanic");

                    b.ToTable("Inspection");
                });

            modelBuilder.Entity("Test2.Models.Mechanic", b =>
                {
                    b.Property<int>("IdMechanic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdMechanic");

                    b.ToTable("Mechanic");
                });

            modelBuilder.Entity("Test2.Models.ServiceTypeDict", b =>
                {
                    b.Property<int>("IdServiceType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdServiceType");

                    b.ToTable("ServiceTypeDict");
                });

            modelBuilder.Entity("Test2.Models.ServiceTypeDictInspection", b =>
                {
                    b.Property<int>("IdServiceType")
                        .HasColumnType("int");

                    b.Property<int>("IdInspection")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("IdServiceType", "IdInspection");

                    b.HasIndex("IdInspection");

                    b.ToTable("ServiceTypeDictInspection");
                });

            modelBuilder.Entity("Test2.Models.Inspection", b =>
                {
                    b.HasOne("Test2.Models.Car", "Car")
                        .WithMany("Inspections")
                        .HasForeignKey("IdCar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test2.Models.Mechanic", "Mechanic")
                        .WithMany("Inspections")
                        .HasForeignKey("IdMechanic")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Mechanic");
                });

            modelBuilder.Entity("Test2.Models.ServiceTypeDictInspection", b =>
                {
                    b.HasOne("Test2.Models.Inspection", "Inspection")
                        .WithMany("ServiceTypeDictInspections")
                        .HasForeignKey("IdInspection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test2.Models.ServiceTypeDict", "ServiceTypeDict")
                        .WithMany("ServiceTypeDictInspections")
                        .HasForeignKey("IdServiceType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inspection");

                    b.Navigation("ServiceTypeDict");
                });

            modelBuilder.Entity("Test2.Models.Car", b =>
                {
                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("Test2.Models.Inspection", b =>
                {
                    b.Navigation("ServiceTypeDictInspections");
                });

            modelBuilder.Entity("Test2.Models.Mechanic", b =>
                {
                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("Test2.Models.ServiceTypeDict", b =>
                {
                    b.Navigation("ServiceTypeDictInspections");
                });
#pragma warning restore 612, 618
        }
    }
}
