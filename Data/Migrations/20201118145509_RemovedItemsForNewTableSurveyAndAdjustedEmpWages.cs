using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Data.Migrations
{
    public partial class RemovedItemsForNewTableSurveyAndAdjustedEmpWages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnviromentSatisfaction",
                table: "EmployeesJobInformation");

            migrationBuilder.DropColumn(
                name: "PerformanceRating",
                table: "EmployeesJobInformation");

            migrationBuilder.DropColumn(
                name: "WorkLifeBalance",
                table: "EmployeesJobInformation");

            migrationBuilder.CreateTable(
                name: "EmployeeVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Attrition = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Over18 = table.Column<string>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: true),
                    Education = table.Column<int>(nullable: false),
                    EducationField = table.Column<string>(nullable: true),
                    BusinessTravel = table.Column<string>(nullable: true),
                    DistanceFromHome = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJobInfoVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeId1 = table.Column<int>(nullable: true),
                    RequestingEmployeeId = table.Column<string>(nullable: true),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    EmployeeCount = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: false),
                    EnviromentSatisfaction = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(nullable: false),
                    JobInvolvement = table.Column<int>(nullable: false),
                    JobLevel = table.Column<int>(nullable: false),
                    JobSatisfaction = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    WorkLifeBalance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJobInfoVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeJobInfoVM_EmployeeVM_RequestingEmployeeId1",
                        column: x => x.RequestingEmployeeId1,
                        principalTable: "EmployeeVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeJobInfoVM_RequestingEmployeeId1",
                table: "EmployeeJobInfoVM",
                column: "RequestingEmployeeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeJobInfoVM");

            migrationBuilder.DropTable(
                name: "EmployeeVM");

            migrationBuilder.AddColumn<int>(
                name: "EnviromentSatisfaction",
                table: "EmployeesJobInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformanceRating",
                table: "EmployeesJobInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkLifeBalance",
                table: "EmployeesJobInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
