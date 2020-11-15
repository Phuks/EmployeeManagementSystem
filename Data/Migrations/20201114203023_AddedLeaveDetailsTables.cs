using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Data.Migrations
{
    public partial class AddedLeaveDetailsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeId = table.Column<string>(nullable: true),
                    NumCompaniesWorked = table.Column<int>(nullable: false),
                    YearsAtCompany = table.Column<int>(nullable: false),
                    YearsCurrentRole = table.Column<int>(nullable: false),
                    YearsSinceLastPromotion = table.Column<int>(nullable: false),
                    YearsWithCurrManager = table.Column<int>(nullable: false),
                    RelationshipSatisfaction = table.Column<int>(nullable: false),
                    TotalWorkingYears = table.Column<int>(nullable: false),
                    TrainingTimesLastYear = table.Column<int>(nullable: false),
                    StockOptionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeHistories_AspNetUsers_RequestingEmployeeId",
                        column: x => x.RequestingEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesJobInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeId = table.Column<string>(nullable: true),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    EmployeeCount = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    EnviromentSatisfaction = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(nullable: true),
                    JobInvolvement = table.Column<int>(nullable: false),
                    JobLevel = table.Column<int>(nullable: false),
                    JobSatisfaction = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    WorkLifeBalance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesJobInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesJobInformation_AspNetUsers_RequestingEmployeeId",
                        column: x => x.RequestingEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesEarnings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyIncome = table.Column<int>(nullable: false),
                    MonthlyRate = table.Column<int>(nullable: false),
                    DailyRate = table.Column<int>(nullable: false),
                    HourlyRate = table.Column<int>(nullable: false),
                    Overtime = table.Column<string>(nullable: true),
                    PercentSalaryHike = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: true),
                    EmployeeJobInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesEarnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesEarnings_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeesEarnings_EmployeesJobInformation_EmployeeJobInfoId",
                        column: x => x.EmployeeJobInfoId,
                        principalTable: "EmployeesJobInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistories_RequestingEmployeeId",
                table: "EmployeeHistories",
                column: "RequestingEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesEarnings_EmployeeId",
                table: "EmployeesEarnings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesEarnings_EmployeeJobInfoId",
                table: "EmployeesEarnings",
                column: "EmployeeJobInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesJobInformation_RequestingEmployeeId",
                table: "EmployeesJobInformation",
                column: "RequestingEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeHistories");

            migrationBuilder.DropTable(
                name: "EmployeesEarnings");

            migrationBuilder.DropTable(
                name: "EmployeesJobInformation");
        }
    }
}
