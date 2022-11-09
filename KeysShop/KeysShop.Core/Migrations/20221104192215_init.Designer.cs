﻿// <auto-generated />
using System;
using KeysShop.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeysShop.Core.Migrations
{
    [DbContext(typeof(KeysShopContext))]
    [Migration("20221104192215_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KeysShop.Core.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("KeysShop.Core.Bucket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Buckets");
                });

            modelBuilder.Entity("KeysShop.Core.BucketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BucketId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("KeyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BucketId");

                    b.HasIndex("KeyId");

                    b.HasIndex("UserId");

                    b.ToTable("BucketItem");
                });

            modelBuilder.Entity("KeysShop.Core.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KeyId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KeyId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Count")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsKeyless")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOriginal")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("Sale")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("KeysShop.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "64a183d9-c9ae-440c-b726-0d93a8385731",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3fcd9034-6915-490a-9091-d6282125b74c",
                            Email = "manager@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MANAGER@KEYSSHOP.COM",
                            NormalizedUserName = "MANAGER@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJWOTA+y8euJi3y9SYNDw4WopC6TKd3fgEuinsB9FwVgE2xNwk4aJ2Yd7uHrkCBtxA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8e1ec647-3716-4426-ba6f-859ca402f6de",
                            TwoFactorEnabled = false,
                            UserName = "manager@keysshop.com"
                        },
                        new
                        {
                            Id = "277ec0d9-95d0-4226-8461-4b8001a84f9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f4fd905-a798-4795-88b4-558e46f6f963",
                            Email = "customer@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER@KEYSSHOP.COM",
                            NormalizedUserName = "CUSTOMER@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMZhAP9D1j8Tf9Qye5xqYtHBY+4ArLNVTQJXB6hzDytz9w47faUe5YawEbk5JZvdRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1bdeeb76-c786-4087-8ebf-fa20a11d6e80",
                            TwoFactorEnabled = false,
                            UserName = "customer@keysshop.com"
                        },
                        new
                        {
                            Id = "be65a422-9838-4602-ab5c-2b6a0d482385",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5ed705cb-aab9-4587-af03-f2c4d25537bb",
                            Email = "admin@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@KEYSSHOP.COM",
                            NormalizedUserName = "ADMIN@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELYk+NNt10UtyiXqIwvPWhGbNbXoIeVRGGiVbg1GygqEeSWrOtOmyp6kD+IMT8zKPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "423cc505-9fa4-4d4b-9a4e-b05a97e060fe",
                            TwoFactorEnabled = false,
                            UserName = "admin@keysshop.com"
                        },
                        new
                        {
                            Id = "72dcbfc5-828a-4c20-b228-1597ad9e9d00",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7c7bfaf-6030-4928-9b0a-734a0f93b108",
                            Email = "consultant@keysshop.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CONSULTANT@KEYSSHOP.COM",
                            NormalizedUserName = "CONSULTANT@KEYSSHOP.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENrBihSt801ii0OLl+m6SVy+pcjOieK/lLZG9VVzR9zRIjxWBp6txBftcJQ+GBMMAw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d6e1cab-85f7-4336-a08e-f5b2e5a6e29d",
                            TwoFactorEnabled = false,
                            UserName = "consultant@keysshop.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d191d0bf-e97a-4553-b9da-02e05cb5588d",
                            ConcurrencyStamp = "89c48a2a-f1c3-4716-9f00-0a176059fdd8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "30402003-0f5b-49a0-b7ac-13bb66400ef9",
                            ConcurrencyStamp = "c94200db-6aae-4db0-81a8-a5544c38f82a",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "c9934176-4d04-4120-a066-c24eed230908",
                            ConcurrencyStamp = "36eaab49-7598-4960-b6e8-30b222c584bc",
                            Name = "Consultant",
                            NormalizedName = "CONSULTANT"
                        },
                        new
                        {
                            Id = "e78efcfa-b117-4e6d-8b2b-9ec09dc24788",
                            ConcurrencyStamp = "f57ce71f-aa06-4e70-8543-efbca8fcb221",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "be65a422-9838-4602-ab5c-2b6a0d482385",
                            RoleId = "d191d0bf-e97a-4553-b9da-02e05cb5588d"
                        },
                        new
                        {
                            UserId = "be65a422-9838-4602-ab5c-2b6a0d482385",
                            RoleId = "30402003-0f5b-49a0-b7ac-13bb66400ef9"
                        },
                        new
                        {
                            UserId = "be65a422-9838-4602-ab5c-2b6a0d482385",
                            RoleId = "e78efcfa-b117-4e6d-8b2b-9ec09dc24788"
                        },
                        new
                        {
                            UserId = "be65a422-9838-4602-ab5c-2b6a0d482385",
                            RoleId = "c9934176-4d04-4120-a066-c24eed230908"
                        },
                        new
                        {
                            UserId = "64a183d9-c9ae-440c-b726-0d93a8385731",
                            RoleId = "30402003-0f5b-49a0-b7ac-13bb66400ef9"
                        },
                        new
                        {
                            UserId = "64a183d9-c9ae-440c-b726-0d93a8385731",
                            RoleId = "e78efcfa-b117-4e6d-8b2b-9ec09dc24788"
                        },
                        new
                        {
                            UserId = "277ec0d9-95d0-4226-8461-4b8001a84f9b",
                            RoleId = "e78efcfa-b117-4e6d-8b2b-9ec09dc24788"
                        },
                        new
                        {
                            UserId = "72dcbfc5-828a-4c20-b228-1597ad9e9d00",
                            RoleId = "e78efcfa-b117-4e6d-8b2b-9ec09dc24788"
                        },
                        new
                        {
                            UserId = "72dcbfc5-828a-4c20-b228-1597ad9e9d00",
                            RoleId = "c9934176-4d04-4120-a066-c24eed230908"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("KeysShop.Core.BucketItem", b =>
                {
                    b.HasOne("KeysShop.Core.Bucket", null)
                        .WithMany("BucketItems")
                        .HasForeignKey("BucketId");

                    b.HasOne("KeysShop.Core.Key", "Key")
                        .WithMany()
                        .HasForeignKey("KeyId");

                    b.HasOne("KeysShop.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Key");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KeysShop.Core.Feedback", b =>
                {
                    b.HasOne("KeysShop.Core.Key", null)
                        .WithMany("feedbacks")
                        .HasForeignKey("KeyId");

                    b.HasOne("KeysShop.Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.HasOne("KeysShop.Core.Brand", "Brand")
                        .WithMany("Keys")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KeysShop.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeysShop.Core.Brand", b =>
                {
                    b.Navigation("Keys");
                });

            modelBuilder.Entity("KeysShop.Core.Bucket", b =>
                {
                    b.Navigation("BucketItems");
                });

            modelBuilder.Entity("KeysShop.Core.Key", b =>
                {
                    b.Navigation("feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}