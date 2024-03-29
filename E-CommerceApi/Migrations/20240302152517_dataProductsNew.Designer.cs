﻿// <auto-generated />
using System;
using E_CommerceApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_CommerceApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240302152517_dataProductsNew")]
    partial class dataProductsNew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_CommerceApi.Models.ProductClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("occupancy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EcomProducts_API");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Yes",
                            CreatedDate = new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1503),
                            Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                            Name = "Jeans",
                            Price = "$50",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            occupancy = 5
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "No",
                            CreatedDate = new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1522),
                            Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                            Name = "Men Shirt",
                            Price = "$20",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            occupancy = 2
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Home",
                            CreatedDate = new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1524),
                            Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                            Name = "Baby Boy",
                            Price = "$10",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            occupancy = 5
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Yes",
                            CreatedDate = new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1525),
                            Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                            Name = "Half Shirt",
                            Price = "$2",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            occupancy = 5
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Yes",
                            CreatedDate = new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1527),
                            Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                            Name = "Full Sleeve",
                            Price = "$500",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            occupancy = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
