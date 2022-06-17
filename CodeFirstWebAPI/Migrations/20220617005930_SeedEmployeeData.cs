using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstWebAPI.Migrations
{
    public partial class SeedEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1L, new DateTime(1997, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "priyalini8@gmail.com", "Priyalini", "Niththiyanantham", "076-888-7777" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2L, new DateTime(1997, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "kishanv@gmail.com", "Kishan", "Vadivel", "076-222-3333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);
        }
    }
}
