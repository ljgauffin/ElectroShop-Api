﻿// <auto-generated />
using System;
using ElectroShop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectroShop.Migrations
{
    [DbContext(typeof(ElectroShopContext))]
    [Migration("20230917044418_UserRoleSeed")]
    partial class UserRoleSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectroShop.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4831c"),
                            Description = "Heladeras"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4832c"),
                            Description = "Notebooks"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4833c"),
                            Description = "Celulares"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4834c"),
                            Description = "Mouses"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4835c"),
                            Description = "Teclados"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4836c"),
                            Description = "Auriculares"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4837c"),
                            Description = "Tablets"
                        },
                        new
                        {
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4838c"),
                            Description = "TVs"
                        });
                });

            modelBuilder.Entity("ElectroShop.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("MinimunQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("DECIMAL");

                    b.Property<string>("WebDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("b3a3096e-4274-4799-a843-380868d4838c"),
                            Active = true,
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4831c"),
                            Depth = 20.0,
                            Description = "Heladera Ciclica Top Mount Hsi-ct291b 273 Lts Blanca",
                            Height = 30.0,
                            MinimunQuantity = 2,
                            Price = 2000m,
                            WebDescription = "HELADERA CICLICA TOP MOUNT SIAM HSI-CT291B 273 LTS BLANCA 220V CAMBIO EN EL SENTIDO DE APERTURA DE PUERTAS",
                            Weight = 250.0,
                            Width = 20.0
                        },
                        new
                        {
                            ProductId = new Guid("b3a3096e-4274-4799-a843-380868d4839c"),
                            Active = true,
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4832c"),
                            Depth = 5.0,
                            Description = "Notebook Lenovo IdeaPad 3i Intel I5",
                            Height = 7.0,
                            MinimunQuantity = 2,
                            Price = 1000m,
                            WebDescription = "La notebook Lenovo 81X700FVUS es una solución tanto para trabajar y estudiar como para entretenerte. Al ser portátil, el escritorio dejará de ser tu único espacio de uso para abrirte las puertas a otros ambientes ya sea en tu casa o en la oficina.",
                            Weight = 0.20000000000000001,
                            Width = 1.0
                        },
                        new
                        {
                            ProductId = new Guid("b3a3096e-4274-4799-a843-380868d4840c"),
                            Active = true,
                            CategoryId = new Guid("b3a3096e-4274-4799-a843-380868d4836c"),
                            Depth = 25.0,
                            Description = "Auriculares in-ear inalámbricos Wave 100TWS",
                            Height = 30.0,
                            MinimunQuantity = 2,
                            Price = 500m,
                            WebDescription = "El formato perfecto para vos. Al ser in-ear, mejoran la calidad del audio y son de tamaño pequeño para poder insertarse en tu oreja.",
                            Weight = 0.80000000000000004,
                            Width = 10.0
                        });
                });

            modelBuilder.Entity("ElectroShop.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                            Description = "User"
                        },
                        new
                        {
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                            Description = "Seller"
                        },
                        new
                        {
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4846c"),
                            Description = "Admin"
                        });
                });

            modelBuilder.Entity("ElectroShop.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.HasAlternateKey("Email");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("b3a3096e-4274-4799-a843-380868d4841c"),
                            Email = "juan@perez.com",
                            Name = "Juan",
                            Password = "12345678",
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4844c"),
                            Surname = "Perez"
                        },
                        new
                        {
                            UserId = new Guid("b3a3096e-4274-4799-a843-380868d4842c"),
                            Email = "pedro@gozales.com",
                            Name = "Pedro",
                            Password = "12345678",
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4845c"),
                            Surname = "Gonzales"
                        },
                        new
                        {
                            UserId = new Guid("b3a3096e-4274-4799-a843-380868d4843c"),
                            Email = "Mario@ramirez.com",
                            Name = "Mario",
                            Password = "12345678",
                            RoleId = new Guid("b3a3096e-4274-4799-a843-380868d4846c"),
                            Surname = "Ramirez"
                        });
                });

            modelBuilder.Entity("ElectroShop.Models.Product", b =>
                {
                    b.HasOne("ElectroShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ElectroShop.Models.User", b =>
                {
                    b.HasOne("ElectroShop.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ElectroShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ElectroShop.Models.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
