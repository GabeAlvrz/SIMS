using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIMS.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CurrentAcademicLevel = table.Column<string>(nullable: true),
                    DegreeProgram = table.Column<string>(nullable: true),
                    CurrentProgram = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    BachelorsStartDate = table.Column<DateTime>(nullable: false),
                    BachelorsMentor = table.Column<string>(nullable: true),
                    BachelorsProjectAdvisor = table.Column<string>(nullable: true),
                    BachelorsThesisAdvisor = table.Column<string>(nullable: true),
                    BachelorsProjectTitle = table.Column<string>(nullable: true),
                    BachelorsThesisTitle = table.Column<string>(nullable: true),
                    BachelorsGradDate = table.Column<DateTime>(nullable: false),
                    MastersStartDate = table.Column<DateTime>(nullable: false),
                    MastersFocus = table.Column<string>(nullable: true),
                    MastersProjectAdvisor = table.Column<string>(nullable: true),
                    MastersThesisAdvisor = table.Column<string>(nullable: true),
                    MastersDefenseDate = table.Column<DateTime>(nullable: false),
                    MastersProjectTitle = table.Column<string>(nullable: true),
                    MastersThesisTitle = table.Column<string>(nullable: true),
                    MastersGradDate = table.Column<DateTime>(nullable: false),
                    DoctoralCandidate = table.Column<string>(nullable: true),
                    DoctorateStartDate = table.Column<DateTime>(nullable: false),
                    DateAcceptedForCandidacy = table.Column<DateTime>(nullable: false),
                    DoctorateAdvisor = table.Column<string>(nullable: true),
                    ExternalAdvisor = table.Column<string>(nullable: true),
                    DissertationDefenseDate = table.Column<DateTime>(nullable: false),
                    DissertationTitle = table.Column<string>(nullable: true),
                    DoctorateGradDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BachelorsMentors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    MentorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BachelorsMentors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_BachelorsMentors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BachelorsProjectAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BachelorsProjectAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_BachelorsProjectAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BachelorsThesisAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BachelorsThesisAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_BachelorsThesisAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorateAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorateAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_DoctorateAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorateCommittees",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FormDate = table.Column<DateTime>(nullable: false),
                    Member1 = table.Column<string>(nullable: true),
                    Member2 = table.Column<string>(nullable: true),
                    Member3 = table.Column<string>(nullable: true),
                    Member4 = table.Column<string>(nullable: true),
                    Member5 = table.Column<string>(nullable: true),
                    Member6 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorateCommittees", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_DoctorateCommittees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ExternalAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastersCommittees",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FormDate = table.Column<DateTime>(nullable: false),
                    Member1 = table.Column<string>(nullable: true),
                    Member2 = table.Column<string>(nullable: true),
                    Member3 = table.Column<string>(nullable: true),
                    Member4 = table.Column<string>(nullable: true),
                    Member5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastersCommittees", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_MastersCommittees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastersProjectAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastersProjectAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_MastersProjectAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MastersThesisAdvisors",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId1 = table.Column<int>(nullable: false),
                    AdvisorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MastersThesisAdvisors", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_MastersThesisAdvisors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BachelorsMentors_UserId1",
                table: "BachelorsMentors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BachelorsProjectAdvisors_UserId1",
                table: "BachelorsProjectAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BachelorsThesisAdvisors_UserId1",
                table: "BachelorsThesisAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorateAdvisors_UserId1",
                table: "DoctorateAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAdvisors_UserId1",
                table: "ExternalAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_MastersProjectAdvisors_UserId1",
                table: "MastersProjectAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_MastersThesisAdvisors_UserId1",
                table: "MastersThesisAdvisors",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BachelorsMentors");

            migrationBuilder.DropTable(
                name: "BachelorsProjectAdvisors");

            migrationBuilder.DropTable(
                name: "BachelorsThesisAdvisors");

            migrationBuilder.DropTable(
                name: "DoctorateAdvisors");

            migrationBuilder.DropTable(
                name: "DoctorateCommittees");

            migrationBuilder.DropTable(
                name: "ExitSurveys");

            migrationBuilder.DropTable(
                name: "ExternalAdvisors");

            migrationBuilder.DropTable(
                name: "GradSeniorSurveys");

            migrationBuilder.DropTable(
                name: "MastersCommittees");

            migrationBuilder.DropTable(
                name: "MastersProjectAdvisors");

            migrationBuilder.DropTable(
                name: "MastersThesisAdvisors");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
