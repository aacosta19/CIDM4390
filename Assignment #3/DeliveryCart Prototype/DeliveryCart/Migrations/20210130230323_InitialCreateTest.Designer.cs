﻿// <auto-generated />
using DeliveryCart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeliveryCart.Migrations
{
    [DbContext(typeof(DeliveryCartContext))]
    [Migration("20210130230323_InitialCreateTest")]
    partial class InitialCreateTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DeliveryCart.Models.Customer", b =>
                {
                    b.Property<string>("CustID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DeliveryCart.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("StoreID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DeliveryCart.Models.Shopper", b =>
                {
                    b.Property<string>("ShopperID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ShopperID");

                    b.ToTable("Shopper");
                });
#pragma warning restore 612, 618
        }
    }
}