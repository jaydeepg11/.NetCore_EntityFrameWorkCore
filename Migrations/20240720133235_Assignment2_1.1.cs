using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment2.Migrations
{
    /// <inheritdoc />
    public partial class Assignment2_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "Name" },
                values: new object[,]
                {
                    { 1, "Angular" },
                    { 2, "Python" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamID", "TeamName" },
                values: new object[,]
                {
                    { 1, "ICONS" },
                    { 2, "STRIKERS" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Name", "TeamID" },
                values: new object[,]
                {
                    { 1, "Abhishek", 1 },
                    { 2, "Basil", 2 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeDetail",
                columns: new[] { "EmployeeDetailID", "Address", "EmployeeID" },
                values: new object[,]
                {
                    { 1, "Maharashtra", 1 },
                    { 2, "Goa", 2 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "EmployeeID", "ProjectID" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeDetail",
                keyColumn: "EmployeeDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeDetail",
                keyColumn: "EmployeeDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjects",
                keyColumns: new[] { "EmployeeID", "ProjectID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamID",
                keyValue: 2);
        }
    }
}
