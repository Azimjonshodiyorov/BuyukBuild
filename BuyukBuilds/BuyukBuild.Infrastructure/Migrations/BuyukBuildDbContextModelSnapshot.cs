﻿// <auto-generated />
using System;
using BuyukBuild.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuyukBuild.Infrastructure.Migrations
{
    [DbContext(typeof(BuyukBuildDbContext))]
    partial class BuyukBuildDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Address.AddressData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Strength")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("strength");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.ToTable("address_data", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Auth.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CardId")
                        .HasColumnType("bigint")
                        .HasColumnName("card_id");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTimeOffset>("DateOfBrith")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_brith");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("boolean")
                        .HasColumnName("is_bloked");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer")
                        .HasColumnName("user_role");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("user", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Cards.Card", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("card_number");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<DateTime>("ExpireData")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expire_data");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("card", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Carts.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("cart", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("ParentId")
                        .HasColumnType("bigint")
                        .HasColumnName("parent_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.ToTable("category", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Comments.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("comment", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Company.CompanyData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AddresId")
                        .HasColumnType("bigint")
                        .HasColumnName("address_id");

                    b.Property<long>("CardId")
                        .HasColumnType("bigint")
                        .HasColumnName("card_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.HasIndex("AddresId")
                        .IsUnique();

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("company_data", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Discounts.Discount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("Procent")
                        .HasColumnType("double precision")
                        .HasColumnName("procent");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.ToTable("discount", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.OrderLists.OrderList", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint")
                        .HasColumnName("order_id");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint")
                        .HasColumnName("product_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("order_list", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("order", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<long>("CompanyId")
                        .HasColumnType("bigint")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<long>("DiscountId")
                        .HasColumnType("bigint")
                        .HasColumnName("discount_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<int>("ProductStatus")
                        .HasColumnType("integer")
                        .HasColumnName("product_status");

                    b.Property<long>("StaticFilesId")
                        .HasColumnType("bigint")
                        .HasColumnName("static_file_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.HasIndex("DiscountId")
                        .IsUnique();

                    b.HasIndex("StaticFilesId");

                    b.ToTable("product", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.StaticFiles.StaticFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("create_at");

                    b.Property<DateTime>("DeleteAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delete_at");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("file_extension");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("path");

                    b.Property<long>("Size")
                        .HasColumnType("bigint")
                        .HasColumnName("size");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_at");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("static_files", "buyukbuild");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Auth.User", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Cards.Card", "Card")
                        .WithOne("User")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Auth.User", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Carts.Cart", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Products.Product", "Product")
                        .WithOne("Cart")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Carts.Cart", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Auth.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Comments.Comment", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Products.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Auth.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Company.CompanyData", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Address.AddressData", "Address")
                        .WithOne("CompanyData")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Company.CompanyData", "AddresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Cards.Card", "Card")
                        .WithOne("CompanyData")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Company.CompanyData", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.OrderLists.OrderList", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Orders.Order", "Order")
                        .WithMany("OrderLists")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Products.Product", "Product")
                        .WithMany("OrderLists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Auth.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("BuyukBuild.Domain.Entities.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Company.CompanyData", "CompanyData")
                        .WithOne("Product")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Products.Product", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.Discounts.Discount", "Discount")
                        .WithOne("Product")
                        .HasForeignKey("BuyukBuild.Domain.Entities.Products.Product", "DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuyukBuild.Domain.Entities.StaticFiles.StaticFile", "StaticFile")
                        .WithMany("Products")
                        .HasForeignKey("StaticFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CompanyData");

                    b.Navigation("Discount");

                    b.Navigation("StaticFile");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Address.AddressData", b =>
                {
                    b.Navigation("CompanyData")
                        .IsRequired();
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Auth.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Cards.Card", b =>
                {
                    b.Navigation("CompanyData")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Company.CompanyData", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Discounts.Discount", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Orders.Order", b =>
                {
                    b.Navigation("OrderLists");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.Products.Product", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("OrderLists");
                });

            modelBuilder.Entity("BuyukBuild.Domain.Entities.StaticFiles.StaticFile", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
