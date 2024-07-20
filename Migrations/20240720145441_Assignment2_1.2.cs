using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Migrations
{
    /// <inheritdoc />
    public partial class Assignment2_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetail_Employees_EmployeeID",
                table: "EmployeeDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Team_EmployeeID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "EmployeeDetail",
                newName: "EmployeeDetails");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeDetail_EmployeeID",
                table: "EmployeeDetails",
                newName: "IX_EmployeeDetails_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails",
                column: "EmployeeDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Employees_EmployeeID",
                table: "EmployeeDetails",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Teams_EmployeeID",
                table: "Employees",
                column: "EmployeeID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Employees_EmployeeID",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Teams_EmployeeID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "EmployeeDetails",
                newName: "EmployeeDetail");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeDetails_EmployeeID",
                table: "EmployeeDetail",
                newName: "IX_EmployeeDetail_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail",
                column: "EmployeeDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetail_Employees_EmployeeID",
                table: "EmployeeDetail",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Team_EmployeeID",
                table: "Employees",
                column: "EmployeeID",
                principalTable: "Team",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
