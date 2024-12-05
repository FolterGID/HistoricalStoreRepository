﻿// <auto-generated />
using System;
using HistoricalStore.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HistoricalStore.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20241204184519_UserOrderDublDva")]
    partial class UserOrderDublDva
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HistoricalPeriodProduct", b =>
                {
                    b.Property<int>("HistoricalPeriodsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("HistoricalPeriodsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("HistoricalPeriodProduct");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.SupplyModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Оружие"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Одежда"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Книги"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Сувениры"
                        });
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.SupplyModels.HistoricalPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HistoricalPeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Древний мир"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Античность"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Средневековье"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ренессанс"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Новое время"
                        });
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.SupplyModels.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Дерево (дуб)"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Дерево (кедр)"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Сталь, закаленная"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Железо, кованое"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Золото, 585 проба"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Серебро, 925 проба"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Кожа (натуральная, телячья)"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Кожа (замша, натуральная)"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ткань (лен, грубый)"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ткань (шелк, китайский)"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Керамика (майолика)"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Керамика (фарфор, европейский)"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Мрамор, каррарский"
                        });
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.UserModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Администратор"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Менеджер"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Клиент"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Гость"
                        });
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MaterialProduct", b =>
                {
                    b.Property<int>("MaterialsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("MaterialsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("MaterialProduct");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Accessory", b =>
                {
                    b.HasBaseType("HistoricalStore.Data.Models.ProductModels.Product");

                    b.Property<string>("AccessoryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Accessories", (string)null);
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Armor", b =>
                {
                    b.HasBaseType("HistoricalStore.Data.Models.ProductModels.Product");

                    b.Property<string>("ArmorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.ToTable("Armors", (string)null);
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Book", b =>
                {
                    b.HasBaseType("HistoricalStore.Data.Models.ProductModels.Product");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Weapon", b =>
                {
                    b.HasBaseType("HistoricalStore.Data.Models.ProductModels.Product");

                    b.Property<bool>("IsSharp")
                        .HasColumnType("bit");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("WeaponType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.ToTable("Weapons", (string)null);
                });

            modelBuilder.Entity("HistoricalPeriodProduct", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.SupplyModels.HistoricalPeriod", null)
                        .WithMany()
                        .HasForeignKey("HistoricalPeriodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.Order", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.OrderModels.OrderStatus", null)
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HistoricalStore.Data.Models.UserModels.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HistoricalStore.Data.Models.UserModels.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.OrderItem", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.OrderModels.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Product", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.SupplyModels.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.UserModels.User", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.UserModels.Role", null)
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaterialProduct", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.SupplyModels.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Accessory", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithOne()
                        .HasForeignKey("HistoricalStore.Data.Models.ProductModels.Accessory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Armor", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithOne()
                        .HasForeignKey("HistoricalStore.Data.Models.ProductModels.Armor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Book", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithOne()
                        .HasForeignKey("HistoricalStore.Data.Models.ProductModels.Book", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.ProductModels.Weapon", b =>
                {
                    b.HasOne("HistoricalStore.Data.Models.ProductModels.Product", null)
                        .WithOne()
                        .HasForeignKey("HistoricalStore.Data.Models.ProductModels.Weapon", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.OrderModels.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.SupplyModels.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.UserModels.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("HistoricalStore.Data.Models.UserModels.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}