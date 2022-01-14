﻿// <auto-generated />
using Lubes.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SAINA.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220106080800_v1767676")]
    partial class v1767676
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SAINA.Models.Clients", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Client_name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("account_balance")
                        .HasColumnType("float");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SAINA.Models.Deliveries", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("D_Number")
                        .HasColumnType("int");

                    b.Property<string>("Delivered_by")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("LPO_Number")
                        .HasColumnType("int");

                    b.Property<string>("M_s")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Received_by")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("SAINA.Models.Invoices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Delivery_no")
                        .HasColumnType("int");

                    b.Property<int>("LPO_Number")
                        .HasColumnType("int");

                    b.Property<string>("M_s")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("SAINA.Models.Log_in", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone_number")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Shop_name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Log_in");
                });

            modelBuilder.Entity("SAINA.Models.Particulars", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Item_name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("category")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<int>("delivery_no")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<float>("total")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Particulars");
                });

            modelBuilder.Entity("SAINA.Models.Receipts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Particulars")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Payment_mode")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Received_from")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.Property<string>("check_number")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Receipts");
                });
#pragma warning restore 612, 618
        }
    }
}
