using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "39a705de-34b1-42a2-8383-0f9f89d27918", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDKQJfo6I4oN/H8rvnMAk9JoCpnJNET/2x3T+8urEdBMFcF5e6hDhPeBmFh4g/0mwQ==", null, false, "6f9e43e8-9bb4-4820-a568-b01a97095f08", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(3648), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(3678), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4216), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4609), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4622), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4626), new DateTime(2025, 12, 3, 4, 23, 22, 162, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5469), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5788), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5792), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5924), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5934), new DateTime(2025, 12, 3, 4, 12, 41, 745, DateTimeKind.Local).AddTicks(5935) });
        }
    }
}
