using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shrimp.Data.Migrations
{
    public partial class ZacksFixedMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfDistrict = table.Column<int>(type: "int", nullable: false),
                    CrimeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Curfew = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeForDress = table.Column<int>(type: "int", nullable: false),
                    AvailableResources = table.Column<int>(type: "int", nullable: false),
                    PermitsNeeded = table.Column<int>(type: "int", nullable: false),
                    WalkabilityRating = table.Column<int>(type: "int", nullable: false),
                    SchoolsId = table.Column<int>(type: "int", nullable: false),
                    HousesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    TypeOfClasses = table.Column<int>(type: "int", nullable: false),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    TeacherStudentRatio = table.Column<float>(type: "real", nullable: false),
                    Costs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TypeOfASP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.SchoolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
