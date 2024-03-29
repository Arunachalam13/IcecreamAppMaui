﻿// <auto-generated />
using System;
using IcecreamMAUI.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IcecreamMAUI.Api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240316104042_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.Icecream", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Icecreams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_0.jpg",
                            Name = "Vanilla Delight",
                            Price = 6.25
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_1.jpg",
                            Name = "ChocoBerry Bliss",
                            Price = 7.5
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_2.jpg",
                            Name = "Minty Cookie Crunch",
                            Price = 8.75
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_3.jpg",
                            Name = "Strawberry Dream",
                            Price = 6.9500000000000002
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_4.jpg",
                            Name = "Cookie Dough Extravaganza",
                            Price = 9.1999999999999993
                        },
                        new
                        {
                            Id = 6,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_5.jpg",
                            Name = "Caramel Swirl Symphony",
                            Price = 7.75
                        },
                        new
                        {
                            Id = 7,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_6.jpg",
                            Name = "Peanut Butter Paradise",
                            Price = 8.5
                        },
                        new
                        {
                            Id = 8,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_7.jpg",
                            Name = "Mango Tango Tango",
                            Price = 9.8000000000000007
                        },
                        new
                        {
                            Id = 9,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_8.jpg",
                            Name = "Hazelnut Heaven",
                            Price = 8.9499999999999993
                        },
                        new
                        {
                            Id = 10,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_9.jpg",
                            Name = "Blueberry Bliss Bonanza",
                            Price = 7.2000000000000002
                        },
                        new
                        {
                            Id = 11,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_10.jpg",
                            Name = "Toffee Twist Temptation",
                            Price = 7.9500000000000002
                        },
                        new
                        {
                            Id = 12,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_11.jpg",
                            Name = "Rocky Road Revelry",
                            Price = 9.5
                        },
                        new
                        {
                            Id = 13,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_12.jpg",
                            Name = "Passionfruit Paradise",
                            Price = 8.75
                        },
                        new
                        {
                            Id = 14,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_13.jpg",
                            Name = "Cotton Candy Carnival",
                            Price = 7.2000000000000002
                        },
                        new
                        {
                            Id = 15,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_14.jpg",
                            Name = "Lemon Sorbet Serenity",
                            Price = 6.9000000000000004
                        },
                        new
                        {
                            Id = 16,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_15.jpg",
                            Name = "Maple Pecan Pleasure",
                            Price = 8.25
                        },
                        new
                        {
                            Id = 17,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_16.jpg",
                            Name = "Raspberry Ripple Rhapsody",
                            Price = 7.4500000000000002
                        },
                        new
                        {
                            Id = 18,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_17.jpg",
                            Name = "Almond Joyful Jubilee",
                            Price = 9.9499999999999993
                        },
                        new
                        {
                            Id = 19,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_18.jpg",
                            Name = "Blue Lagoon Bliss",
                            Price = 8.5
                        },
                        new
                        {
                            Id = 20,
                            Image = "https://github.com/Arunachalam13/Images-Icons-Repo/blob/AddIcecream/low-qty/ic_19.jpg",
                            Name = "Coconut Caramel Carnival",
                            Price = 7.7999999999999998
                        });
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.IcecreamOption", b =>
                {
                    b.Property<int>("IcecreamId")
                        .HasColumnType("int");

                    b.Property<string>("Topping")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Flavor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IcecreamId", "Topping", "Flavor");

                    b.ToTable("IcecreamOptions");

                    b.HasData(
                        new
                        {
                            IcecreamId = 1,
                            Topping = "Default",
                            Flavor = "Vanilla"
                        },
                        new
                        {
                            IcecreamId = 1,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 1,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 2,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 2,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 2,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 3,
                            Topping = "Default",
                            Flavor = "Mint Chocolate Chip"
                        },
                        new
                        {
                            IcecreamId = 3,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 3,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 4,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 4,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 4,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 5,
                            Topping = "Default",
                            Flavor = "Cookie Dough"
                        },
                        new
                        {
                            IcecreamId = 5,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 5,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 6,
                            Topping = "Default",
                            Flavor = "Vanilla"
                        },
                        new
                        {
                            IcecreamId = 6,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 6,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 7,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 7,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 7,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 8,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 8,
                            Topping = "Default",
                            Flavor = "Cookie Dough"
                        },
                        new
                        {
                            IcecreamId = 8,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 9,
                            Topping = "Default",
                            Flavor = "Mint Chocolate Chip"
                        },
                        new
                        {
                            IcecreamId = 9,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 9,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 10,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 10,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 10,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 11,
                            Topping = "Default",
                            Flavor = "Vanilla"
                        },
                        new
                        {
                            IcecreamId = 11,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 11,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 12,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 12,
                            Topping = "Default",
                            Flavor = "Mini Chocolate"
                        },
                        new
                        {
                            IcecreamId = 12,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 13,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 13,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 13,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 14,
                            Topping = "Default",
                            Flavor = "Cookie Dough"
                        },
                        new
                        {
                            IcecreamId = 14,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 14,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 15,
                            Topping = "Default",
                            Flavor = "Vanilla"
                        },
                        new
                        {
                            IcecreamId = 15,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 15,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 16,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 16,
                            Topping = "Default",
                            Flavor = "Mint Chocolate Chip"
                        },
                        new
                        {
                            IcecreamId = 16,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 17,
                            Topping = "Default",
                            Flavor = "Strawbeery"
                        },
                        new
                        {
                            IcecreamId = 17,
                            Topping = "Default",
                            Flavor = "Cookie Dough"
                        },
                        new
                        {
                            IcecreamId = 17,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 18,
                            Topping = "Default",
                            Flavor = "Vanilla"
                        },
                        new
                        {
                            IcecreamId = 18,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 18,
                            Topping = "Cherries",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 19,
                            Topping = "Default",
                            Flavor = "Chocolate"
                        },
                        new
                        {
                            IcecreamId = 19,
                            Topping = "Default",
                            Flavor = "Strawberry"
                        },
                        new
                        {
                            IcecreamId = 19,
                            Topping = "Whipped Cream",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 20,
                            Topping = "Default",
                            Flavor = "Mint Choclate Chip"
                        },
                        new
                        {
                            IcecreamId = 20,
                            Topping = "Chocolate Sauce",
                            Flavor = "Default"
                        },
                        new
                        {
                            IcecreamId = 20,
                            Topping = "Sprinkles",
                            Flavor = "Default"
                        });
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("OrderAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Flavor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IcecreamId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Topping")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.IcecreamOption", b =>
                {
                    b.HasOne("IcecreamMAUI.Api.Data.Entities.Icecream", "Icecream")
                        .WithMany("Options")
                        .HasForeignKey("IcecreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icecream");
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.OrderItem", b =>
                {
                    b.HasOne("IcecreamMAUI.Api.Data.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("IcecreamMAUI.Api.Data.Entities.Icecream", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
