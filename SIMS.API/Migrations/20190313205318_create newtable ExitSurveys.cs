using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIMS.API.Migrations
{
    public partial class createnewtableExitSurveys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExitSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    surveyDate = table.Column<DateTime>(nullable: false),
                    studentName = table.Column<string>(nullable: true),
                    ssId = table.Column<string>(nullable: true),
                    degreeProgram = table.Column<string>(nullable: true),
                    termGraDuateSemester = table.Column<string>(nullable: true),
                    termGraDuateYear = table.Column<string>(nullable: true),
                    contact1Name = table.Column<string>(nullable: true),
                    contact1PhoneHome = table.Column<string>(nullable: true),
                    contact1PhoneWork = table.Column<string>(nullable: true),
                    contact1PhoneCell = table.Column<string>(nullable: true),
                    contact1Address = table.Column<string>(nullable: true),
                    contact1Email = table.Column<string>(nullable: true),
                    contactOtherOption = table.Column<string>(nullable: true),
                    contact2Name = table.Column<string>(nullable: true),
                    contact2PhoneHome = table.Column<string>(nullable: true),
                    contact2PhoneWork = table.Column<string>(nullable: true),
                    contact2PhoneCell = table.Column<string>(nullable: true),
                    contact2Address = table.Column<string>(nullable: true),
                    contact2Email = table.Column<string>(nullable: true),
                    assessQ1 = table.Column<string>(nullable: true),
                    assessQ2 = table.Column<string>(nullable: true),
                    assessQ3 = table.Column<string>(nullable: true),
                    assessComment = table.Column<string>(nullable: true),
                    furtherStudySchool = table.Column<string>(nullable: true),
                    furtherStudyMajor = table.Column<string>(nullable: true),
                    furtherStudyScholarship = table.Column<string>(nullable: true),
                    jobSearchDuration = table.Column<string>(nullable: true),
                    jobSearchNumInterview = table.Column<string>(nullable: true),
                    jobSearchNumOffer = table.Column<string>(nullable: true),
                    jobSearchAvgSalary = table.Column<string>(nullable: true),
                    jobCompany = table.Column<string>(nullable: true),
                    jobCity = table.Column<string>(nullable: true),
                    jobTitle = table.Column<string>(nullable: true),
                    jobCompanyContact = table.Column<string>(nullable: true),
                    jobCompanyWeb = table.Column<string>(nullable: true),
                    jobSalary = table.Column<string>(nullable: true),
                    networkingQ1 = table.Column<string>(nullable: true),
                    networkingQ2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExitSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GradSeniorSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    surveyDate = table.Column<DateTime>(nullable: false),
                    degreeProgram = table.Column<string>(nullable: true),
                    termGraduateSemester = table.Column<string>(nullable: true),
                    termGraduateYear = table.Column<string>(nullable: true),
                    Obj1 = table.Column<string>(nullable: true),
                    Obj2 = table.Column<string>(nullable: true),
                    Obj3 = table.Column<string>(nullable: true),
                    Obj4 = table.Column<string>(nullable: true),
                    Obj5 = table.Column<string>(nullable: true),
                    Outcome1 = table.Column<string>(nullable: true),
                    Outcome2 = table.Column<string>(nullable: true),
                    Outcome3 = table.Column<string>(nullable: true),
                    Outcome4 = table.Column<string>(nullable: true),
                    Outcome5 = table.Column<string>(nullable: true),
                    Outcome6 = table.Column<string>(nullable: true),
                    Outcome7 = table.Column<string>(nullable: true),
                    Outcome8 = table.Column<string>(nullable: true),
                    Outcome9 = table.Column<string>(nullable: true),
                    Outcome10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradSeniorSurveys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExitSurveys");

            migrationBuilder.DropTable(
                name: "GradSeniorSurveys");
        }
    }
}
