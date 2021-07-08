﻿// <auto-generated />
using System;
using CarFish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarFish.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210707144727_mysql_transfer")]
    partial class mysql_transfer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarFish.Models.Images", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("text");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ImageURL = "https://i.imgur.com/APSUSkV.jpg",
                            ProductID = 1
                        },
                        new
                        {
                            ID = 2,
                            ImageURL = "https://i.imgur.com/FSTeMK2.jpg",
                            ProductID = 1
                        },
                        new
                        {
                            ID = 3,
                            ImageURL = "https://i.imgur.com/qKxxqUb.jpg",
                            ProductID = 1
                        },
                        new
                        {
                            ID = 4,
                            ImageURL = "https://i.imgur.com/QfIRm5K.jpg",
                            ProductID = 1
                        });
                });

            modelBuilder.Entity("CarFish.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("InStock")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ImageThumbnailUrl = "https://i.imgur.com/jDlwQfT.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "მანქანის გადასაფარებელი",
                            Price = 12m,
                            ShortDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში"
                        },
                        new
                        {
                            ProductId = 2,
                            ImageThumbnailUrl = "https://i.imgur.com/jM45dWU.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "ჩაიდანი",
                            Price = 14m,
                            ShortDescription = "ჩაიდანი მოკლედ რაღაც ინფორმაცია"
                        },
                        new
                        {
                            ProductId = 3,
                            ImageThumbnailUrl = "https://i.imgur.com/AIwoQYN.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "ანკესი",
                            Price = 16m,
                            ShortDescription = "ანკესი მოკლედ"
                        },
                        new
                        {
                            ProductId = 4,
                            ImageThumbnailUrl = "https://i.imgur.com/jDlwQfT.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "მანქანის გადასაფარებელი",
                            Price = 12m,
                            ShortDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში"
                        },
                        new
                        {
                            ProductId = 5,
                            ImageThumbnailUrl = "https://i.imgur.com/jM45dWU.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "ჩაიდანი",
                            Price = 14m,
                            ShortDescription = "ჩაიდანი მოკლედ რაღაც ინფორმაცია"
                        },
                        new
                        {
                            ProductId = 6,
                            ImageThumbnailUrl = "https://i.imgur.com/AIwoQYN.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "ანკესი",
                            Price = 16m,
                            ShortDescription = "ანკესი მოკლედ"
                        },
                        new
                        {
                            ProductId = 7,
                            ImageThumbnailUrl = "https://i.imgur.com/jDlwQfT.png",
                            InStock = true,
                            IsFeatured = true,
                            LongDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში ლორემ იპსუმ",
                            Name = "მანქანის გადასაფარებელი",
                            Price = 12m,
                            ShortDescription = "მანქანის 'ჩიხოლები' გვაქვს ორ ფერში ლურჯში და ნაცრისფერში"
                        });
                });

            modelBuilder.Entity("CarFish.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("text");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CarFish.Models.Images", b =>
                {
                    b.HasOne("CarFish.Models.Product", null)
                        .WithMany("AllImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarFish.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CarFish.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}