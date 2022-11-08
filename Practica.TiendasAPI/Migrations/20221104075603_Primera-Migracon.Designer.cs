﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practica.TiendasAPI.DbContexts;

#nullable disable

namespace Practica.TiendasAPI.Migrations
{
    [DbContext(typeof(TiendaContext))]
    [Migration("20221104075603_Primera-Migracon")]
    partial class PrimeraMigracon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Practica.TiendasAPI.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ShopId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pan",
                            Price = 0.29999999999999999,
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cruzcampo 1L",
                            Price = 1.0,
                            ShopId = 2
                        });
                });

            modelBuilder.Entity("Practica.TiendasAPI.Entities.Tienda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pan recién hecho.",
                            Name = "Panadería Paqui"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Todo a 1€.",
                            Name = "Bazar Todo a 1"
                        });
                });

            modelBuilder.Entity("Practica.TiendasAPI.Entities.Producto", b =>
                {
                    b.HasOne("Practica.TiendasAPI.Entities.Tienda", "Shop")
                        .WithMany("InterestPoints")
                        .HasForeignKey("CityId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Practica.TiendasAPI.Entities.Tienda", b =>
                {
                    b.Navigation("InterestPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
