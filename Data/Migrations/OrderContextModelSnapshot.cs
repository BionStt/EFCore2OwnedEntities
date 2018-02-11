﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OwnedEntityDemo;
using System;

namespace OwnedEntityTipsNTricks.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("OwnedEntityDemo.SalesOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("OrderTotal");

                    b.HasKey("Id");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("OwnedEntityDemo.SalesOrder", b =>
                {
                    b.OwnsOne("OwnedEntityDemo.Address", "BillingAddress", b1 =>
                        {
                            b1.Property<int>("SalesOrderId");

                            b1.Property<string>("City");

                            b1.Property<string>("PostalCode");

                            b1.Property<string>("Region");

                            b1.Property<string>("Street");

                            b1.ToTable("SalesOrders");

                            b1.HasOne("OwnedEntityDemo.SalesOrder")
                                .WithOne("BillingAddress")
                                .HasForeignKey("OwnedEntityDemo.Address", "SalesOrderId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("OwnedEntityDemo.Address", "ShippingAddress", b1 =>
                        {
                            b1.Property<int?>("SalesOrderId");

                            b1.Property<string>("City");

                            b1.Property<string>("PostalCode");

                            b1.Property<string>("Region");

                            b1.Property<string>("Street");

                            b1.ToTable("SalesOrders");

                            b1.HasOne("OwnedEntityDemo.SalesOrder")
                                .WithOne("ShippingAddress")
                                .HasForeignKey("OwnedEntityDemo.Address", "SalesOrderId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}