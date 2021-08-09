using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Safe365__Proj.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BusinessName", "DateCreated", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 1, "beerpub@gmail.com", new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(6607), new DateTime(2021, 8, 6, 21, 0, 56, 664, DateTimeKind.Local).AddTicks(2868), "personA", "LastNameA" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BusinessName", "DateCreated", "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { 2, "beerpub@gmail.com", new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(7117), new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(7090), "PersonB", "LastNameB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
