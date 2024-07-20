using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2.Migrations
{
    /// <inheritdoc />
    public partial class Assignment2_13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetail_employees_EmployeeID",
                table: "EmployeeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail");

            migrationBuilder.RenameTable(
                name: "EmployeeDetail",
                newName: "EmployeeDetails");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeDetail_EmployeeID",
                table: "EmployeeDetails",
                newName: "IX_EmployeeDetails_EmployeeID");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeRolesID",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "employeeRoles",
                columns: table => new
                {
                    EmployeeRolesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeRoles", x => x.EmployeeRolesID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeRolesID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolesID);
                    table.ForeignKey(
                        name: "FK_Roles_employeeRoles_EmployeeRolesID",
                        column: x => x.EmployeeRolesID,
                        principalTable: "employeeRoles",
                        principalColumn: "EmployeeRolesID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_EmployeeRolesID",
                table: "employees",
                column: "EmployeeRolesID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeRolesID",
                table: "Roles",
                column: "EmployeeRolesID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_employees_EmployeeID",
                table: "EmployeeDetails",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_employeeRoles_EmployeeRolesID",
                table: "employees",
                column: "EmployeeRolesID",
                principalTable: "employeeRoles",
                principalColumn: "EmployeeRolesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_employees_EmployeeID",
                table: "EmployeeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_employeeRoles_EmployeeRolesID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "employeeRoles");

            migrationBuilder.DropIndex(
                name: "IX_employees_EmployeeRolesID",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "EmployeeRolesID",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "EmployeeDetails",
                newName: "EmployeeDetail");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeDetails_EmployeeID",
                table: "EmployeeDetail",
                newName: "IX_EmployeeDetail_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetail_employees_EmployeeID",
                table: "EmployeeDetail",
                column: "EmployeeID",
                principalTable: "employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
