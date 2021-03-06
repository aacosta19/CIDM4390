﻿// <auto-generated />
using System;
using DeliveryCart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeliveryCart.Migrations
{
    [DbContext(typeof(DeliveryCartContext))]
    [Migration("20210130150928_InitialCreate")]
    partial class InitialCreate
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

            modelBuilder.Entity("DeliveryCart.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerCustID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderDateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperID")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerCustID");

                    b.HasIndex("ShopperID");

                    b.ToTable("Order");
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

            modelBuilder.Entity("DeliveryCart.Models.Order", b =>
                {
                    b.HasOne("DeliveryCart.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerCustID");

                    b.HasOne("DeliveryCart.Models.Shopper", "Shopper")
                        .WithMany()
                        .HasForeignKey("ShopperID");

                    b.Navigation("Customer");

                    b.Navigation("Shopper");
                });
#pragma warning restore 612, 618
        }
    }
}
