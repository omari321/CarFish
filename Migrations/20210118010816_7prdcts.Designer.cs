﻿// <auto-generated />
using CarFish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarFish.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210118010816_7prdcts")]
    partial class _7prdcts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarFish.Models.Images", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("CarFish.Models.Images", b =>
                {
                    b.HasOne("CarFish.Models.Product", null)
                        .WithMany("AllImages")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
