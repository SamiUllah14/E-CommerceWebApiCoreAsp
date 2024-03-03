using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_CommerceApi.Migrations
{
    /// <inheritdoc />
    public partial class dataProductsNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EcomProducts_API",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "UpdateDate", "occupancy" },
                values: new object[,]
                {
                    { 1, "Yes", new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1503), "DescriptionDescriptionDescriptionDescriptionDescription", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE", "Jeans", "$50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 2, "No", new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1522), "DescriptionDescriptionDescriptionDescriptionDescription", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE", "Men Shirt", "$20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Home", new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1524), "DescriptionDescriptionDescriptionDescriptionDescription", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE", "Baby Boy", "$10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 4, "Yes", new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1525), "DescriptionDescriptionDescriptionDescriptionDescription", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE", "Half Shirt", "$2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 5, "Yes", new DateTime(2024, 3, 2, 20, 25, 17, 375, DateTimeKind.Local).AddTicks(1527), "DescriptionDescriptionDescriptionDescriptionDescription", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE", "Full Sleeve", "$500", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EcomProducts_API",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EcomProducts_API",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EcomProducts_API",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EcomProducts_API",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EcomProducts_API",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
