using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VirtualHealthProject.Migrations
{
    /// <inheritdoc />
    public partial class _1st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsumableStockLevels",
                columns: table => new
                {
                    ConsumableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockLevel = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumableStockLevels", x => x.ConsumableId);
                });

            migrationBuilder.CreateTable(
                name: "DispenceMedication",
                columns: table => new
                {
                    DispenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispenceMedication", x => x.DispenceId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorVisit",
                columns: table => new
                {
                    VisitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChronicConditions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ScheduleVMedication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChronicConditionsStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleIVMedication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduledMedication = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorVisit", x => x.VisitId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "InventoryHistories",
                columns: table => new
                {
                    InventoryHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumableId = table.Column<int>(type: "int", nullable: false),
                    MovementType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryHistories", x => x.InventoryHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "NurseDispense",
                columns: table => new
                {
                    DispenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduledMedication = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatePrescribed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseDispense", x => x.DispenceId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryConcern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChronicIllness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMedication = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rx = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sig = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dispense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ReferralLetters",
                columns: table => new
                {
                    ReferralID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryConcern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMedications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralLetters", x => x.ReferralID);
                });

            migrationBuilder.CreateTable(
                name: "RequestConsumables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestConsumables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                });

            migrationBuilder.CreateTable(
                name: "viewConsumablesStocks",
                columns: table => new
                {
                    ConsumableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockLevel = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viewConsumablesStocks", x => x.ConsumableId);
                });

            migrationBuilder.CreateTable(
                name: "Vitals",
                columns: table => new
                {
                    VitalsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PulseRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodPressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PainLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleMedication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scheduleIVMedications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scheduleVMedications = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitals", x => x.VitalsId);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyStockTakes",
                columns: table => new
                {
                    StockTakeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsumableName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    StockNeeded = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyStockTakes", x => x.StockTakeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Admis",
                columns: table => new
                {
                    AdmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admis", x => x.AdmissionId);
                    table.ForeignKey(
                        name: "FK_Admis_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Admis_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admissions",
                columns: table => new
                {
                    AdmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissions", x => x.AdmissionId);
                    table.ForeignKey(
                        name: "FK_Admissions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Admissions_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    AllergyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.AllergyID);
                    table.ForeignKey(
                        name: "FK_Allergies_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChronicIllnesses",
                columns: table => new
                {
                    ChronicIllnessID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChronicIllnesses", x => x.ChronicIllnessID);
                    table.ForeignKey(
                        name: "FK_ChronicIllnesses_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentMedications",
                columns: table => new
                {
                    CurrentMedicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentMedications", x => x.CurrentMedicationID);
                    table.ForeignKey(
                        name: "FK_CurrentMedications_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discharges",
                columns: table => new
                {
                    DischargeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DischargeDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DischargeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discharges", x => x.DischargeId);
                    table.ForeignKey(
                        name: "FK_Discharges_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discharges_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistories",
                columns: table => new
                {
                    MedicalHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistories", x => x.MedicalHistoryID);
                    table.ForeignKey(
                        name: "FK_MedicalHistories_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NurseInstructions",
                columns: table => new
                {
                    InstructionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    RemarkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseInstructions", x => x.InstructionId);
                    table.ForeignKey(
                        name: "FK_NurseInstructions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseInstructions_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientMovements",
                columns: table => new
                {
                    PatientMovementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    Movement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMovements", x => x.PatientMovementID);
                    table.ForeignKey(
                        name: "FK_PatientMovements_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientVisits",
                columns: table => new
                {
                    VisitsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientVisits", x => x.VisitsId);
                    table.ForeignKey(
                        name: "FK_PatientVisits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PatientVisits_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionScripts",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Medication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateWritten = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateForwardedToPharmacy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeliveredToWard = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionScripts", x => x.PrescriptionID);
                    table.ForeignKey(
                        name: "FK_PrescriptionScripts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionScripts_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beds",
                columns: table => new
                {
                    BedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    AllocatedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_occupied = table.Column<bool>(type: "bit", nullable: false),
                    AllocationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beds", x => x.BedID);
                    table.ForeignKey(
                        name: "FK_Beds_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BedAllocation",
                columns: table => new
                {
                    AllocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedID = table.Column<int>(type: "int", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    AllocationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedAllocation", x => x.AllocationID);
                    table.ForeignKey(
                        name: "FK_BedAllocation_Beds_BedID",
                        column: x => x.BedID,
                        principalTable: "Beds",
                        principalColumn: "BedID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedAllocation_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04972214-ed08-4594-9db5-73c50192309c", "04972214-ed08-4594-9db5-73c50192309c", "Administrator", "ADMINISTRATOR" },
                    { "18ebd57b-2075-4ceb-bd1a-e888697dffed", "18ebd57b-2075-4ceb-bd1a-e888697dffed", "Doctor", "DOCTOR" },
                    { "33e37ac0-d18d-49fa-8737-27a50d419f9a", "33e37ac0-d18d-49fa-8737-27a50d419f9a", "WardAdmin", "WARDADMIN" },
                    { "38d828e6-c344-4ec0-b295-3000f6d5ea06", "38d828e6-c344-4ec0-b295-3000f6d5ea06", "Nurse", "NURSE" },
                    { "9fa367bc-0217-4f68-b173-57af2db76cde", "9fa367bc-0217-4f68-b173-57af2db76cde", "Pharmacist", "PHARMACIST" },
                    { "a5395c94-33d2-45f0-a65d-024ff1e18291", "a5395c94-33d2-45f0-a65d-024ff1e18291", "ScriptManager", "SCRIPTMANAGER" },
                    { "bd81ab2b-1df6-4b0e-938b-aa55f1ba5188", "bd81ab2b-1df6-4b0e-938b-aa55f1ba5188", "StockManager", "STOCKMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15a39159-9060-4425-8c3e-ba218c4ca37d", 0, "12d0c8df-e3db-4ae4-91d3-38438bb0b295", "pharmacist@virtualhealthbridge.com", false, "Sheldon", "Brown", false, null, "PHARMACIST@VIRTUALHEALTHBRIDGE.COM", "PHARMACIST@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAENDpKGHMiIPiC/g9Bt9ZRQcyhT9yBa1CRob0Zrl1yhtT15SxicSbQT5dbLS/dZt5qw==", null, false, "3400a816-54ff-461f-a8bb-007ba7d15786", false, "pharmacist@virtualhealthbridge.com" },
                    { "1a9554cf-747d-4afb-81c0-4114eb8f8733", 0, "4fe2d359-b6b9-4abc-a3cb-353989666c59", "wardAdmin@virtualhealthbridge.com", false, "Qulon", "Forbes", false, null, "WARDADMIN@VIRTUALHEALTHBRIDGE.COM", "WARDADMIN@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAEDD8j3RaLqPI5ZDPIqNYFBvhkBlAAJA6y/wHWrvE+ileDV9PENs5Dt9Rj/RgVhAsUQ==", null, false, "d935bbbb-1007-4b24-9e46-480ee016e06c", false, "wardAdmin@virtualhealthbridge.com" },
                    { "7f270bed-70c3-46c2-bd83-c47b73eb7e2d", 0, "244bd1c8-bd9d-49ae-9722-ba03401fa36b", "admin@virtualhealthbridge.com", false, "Justin", "Fourie", false, null, "ADMIN@VIRTUALHEALTHBRIDGE.COM", "ADMIN@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAEHrcJsRpGcB5aGLve8sDDhPWsTdAGO8T3u6dxHeytBAXkD6UPvCqq1Eene0HH5tE+A==", null, false, "97228d0b-1839-465e-8860-31781f771e4c", false, "admin@virtualhealthbridge.com" },
                    { "854428da-d335-45ef-a793-dced73bbff77", 0, "8d5708ed-c425-4045-8628-dcf896be5175", "SCRIPTMANAGER@VIRTUALHEALTHBRIDGE.COM", false, "Bongani", "Kunene", false, null, "SCRIPTMANAGER@VIRTUALHEALTHBRIDGE.COM", "SCRIPTMANAGER@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAEN9AF07Q3AYDrZxdQ2EWDtkPGegXo6DTtezCy1AroqaD1UM8jM77eMXEGxzpJfm2pQ==", null, false, "9644a43b-25e8-42b4-bba8-e86bfaa1269a", false, "scriptmanager@virtualhealthbridge.com" },
                    { "9668a0c8-1c05-4240-b413-18b4c4bf1873", 0, "da6bb06c-b217-4399-a5c6-d16dbbecd952", "NURSE@VIRTUALHEALTHBRIDGE.COM", false, "Juliet", "Links", false, null, "NURSE@VIRTUALHEALTHBRIDGE.COM", "NURSE@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAEJwzYCyGcoB32+v1LGOReq5wzUKGmxMkbUbeWc4GLUSZkEPjZPj2G4H3jPU9lvLIEA==", null, false, "4dbd5407-e4fc-4267-bbbf-4df02ab62785", false, "nurse@virtualhealthbridge.com" },
                    { "a2f48359-0469-43b0-8654-f61b9d1ab286", 0, "64bbbc0a-9119-4bff-b516-a427f1b26389", "stockmanager@virtualhealthbridge.com", false, "Brendon", "Scott", false, null, "STOCKMANAGER@VIRTUALHEALTHBRIDGE.COM", "STOCKMANAGER@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAELoHSRlsBXXgVtBDKVFeYBVOEOzZa9W2GzxzrJUFza8xCFgsIlL+MnEEp+wnw8rHMQ==", null, false, "cff923e9-9068-48d5-9097-71484f796e0f", false, "stockmanager@virtualhealthbridge.com" },
                    { "c4e8abc4-dbbf-406d-8031-20509b79c1a4", 0, "6e6dbbb9-42e8-429f-8a0a-e9568a630537", "DOCTOR@VIRTUALHEALTHBRIDGE.COM", false, "Gregory", "Pikk", false, null, "DOCTOR@VIRTUALHEALTHBRIDGE.COM", "DOCTOR@VIRTUALHEALTHBRIDGE.COM", "AQAAAAIAAYagAAAAECKTZS9f1s3bNYRpVROvjfzHRYOf8OXjZwYSK5EhBKug3u1JqMy0RXelkr2cjlEsJA==", null, false, "a580bd21-a186-4792-b011-66979a33bedb", false, "doctor@virtualhealthbridge.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9fa367bc-0217-4f68-b173-57af2db76cde", "15a39159-9060-4425-8c3e-ba218c4ca37d" },
                    { "04972214-ed08-4594-9db5-73c50192309c", "7f270bed-70c3-46c2-bd83-c47b73eb7e2d" },
                    { "33e37ac0-d18d-49fa-8737-27a50d419f9a", "7f270bed-70c3-46c2-bd83-c47b73eb7e2d" },
                    { "a5395c94-33d2-45f0-a65d-024ff1e18291", "854428da-d335-45ef-a793-dced73bbff77" },
                    { "38d828e6-c344-4ec0-b295-3000f6d5ea06", "9668a0c8-1c05-4240-b413-18b4c4bf1873" },
                    { "bd81ab2b-1df6-4b0e-938b-aa55f1ba5188", "a2f48359-0469-43b0-8654-f61b9d1ab286" },
                    { "18ebd57b-2075-4ceb-bd1a-e888697dffed", "c4e8abc4-dbbf-406d-8031-20509b79c1a4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admis_PatientID",
                table: "Admis",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Admis_UserId",
                table: "Admis",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admissions_PatientID",
                table: "Admissions",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Admissions_UserId",
                table: "Admissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Allergies_PatientID",
                table: "Allergies",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BedAllocation_BedID",
                table: "BedAllocation",
                column: "BedID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BedAllocation_PatientID",
                table: "BedAllocation",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Beds_RoomID",
                table: "Beds",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_ChronicIllnesses_PatientID",
                table: "ChronicIllnesses",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentMedications_PatientID",
                table: "CurrentMedications",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Discharges_PatientID",
                table: "Discharges",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Discharges_UserId",
                table: "Discharges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistories_PatientID",
                table: "MedicalHistories",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseInstructions_PatientID",
                table: "NurseInstructions",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_NurseInstructions_UserId",
                table: "NurseInstructions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMovements_PatientID",
                table: "PatientMovements",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVisits_PatientID",
                table: "PatientVisits",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientVisits_UserId",
                table: "PatientVisits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionScripts_PatientID",
                table: "PrescriptionScripts",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionScripts_UserId",
                table: "PrescriptionScripts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admis");

            migrationBuilder.DropTable(
                name: "Admissions");

            migrationBuilder.DropTable(
                name: "Allergies");

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
                name: "BedAllocation");

            migrationBuilder.DropTable(
                name: "ChronicIllnesses");

            migrationBuilder.DropTable(
                name: "ConsumableStockLevels");

            migrationBuilder.DropTable(
                name: "CurrentMedications");

            migrationBuilder.DropTable(
                name: "Discharges");

            migrationBuilder.DropTable(
                name: "DispenceMedication");

            migrationBuilder.DropTable(
                name: "DoctorVisit");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "InventoryHistories");

            migrationBuilder.DropTable(
                name: "MedicalHistories");

            migrationBuilder.DropTable(
                name: "NurseDispense");

            migrationBuilder.DropTable(
                name: "NurseInstructions");

            migrationBuilder.DropTable(
                name: "PatientMovements");

            migrationBuilder.DropTable(
                name: "PatientVisits");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "PrescriptionScripts");

            migrationBuilder.DropTable(
                name: "ReferralLetters");

            migrationBuilder.DropTable(
                name: "RequestConsumables");

            migrationBuilder.DropTable(
                name: "viewConsumablesStocks");

            migrationBuilder.DropTable(
                name: "Vitals");

            migrationBuilder.DropTable(
                name: "WeeklyStockTakes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Beds");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
