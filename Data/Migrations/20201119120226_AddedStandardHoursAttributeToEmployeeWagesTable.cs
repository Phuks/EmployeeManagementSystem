using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Data.Migrations
{
    public partial class AddedStandardHoursAttributeToEmployeeWagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnviromentSatisfaction",
                table: "EmployeeJobInfoVM");

            migrationBuilder.DropColumn(
                name: "PerformanceRating",
                table: "EmployeeJobInfoVM");

            migrationBuilder.DropColumn(
                name: "WorkLifeBalance",
                table: "EmployeeJobInfoVM");

            migrationBuilder.AddColumn<int>(
                name: "StandardHours",
                table: "EmployeesEarnings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StandardHours",
                table: "EmployeesEarnings");

            migrationBuilder.AddColumn<int>(
                name: "EnviromentSatisfaction",
                table: "EmployeeJobInfoVM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceRating",
                table: "EmployeeJobInfoVM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkLifeBalance",
                table: "EmployeeJobInfoVM",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
