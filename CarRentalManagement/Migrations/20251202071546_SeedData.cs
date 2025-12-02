using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Make",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Make", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4473), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4483), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4485), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4486), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4666), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4666), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4668), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4669), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4740), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4741), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4743), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4743), "x5", "System" },
                    { 3, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4745), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4745), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4747), new DateTime(2025, 12, 2, 15, 15, 45, 409, DateTimeKind.Local).AddTicks(4747), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Make");

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
