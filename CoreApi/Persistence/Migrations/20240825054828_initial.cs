using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SF_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HR_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BM_BranchID = table.Column<int>(type: "int", nullable: false),
                    BM_BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HR_DesgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HR_DesgID = table.Column<int>(type: "int", nullable: true),
                    HR_DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HR_DeptID = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityInv_CountryID = table.Column<int>(type: "int", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mgr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RetireDateApproximate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RetireDateActual = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CauseOfSeparation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CauseOfSeparationBM_ItemID = table.Column<int>(type: "int", nullable: true),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationDateApprox = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MinimumDaysOfConfirmation = table.Column<int>(type: "int", nullable: true),
                    GrandeBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    GrandeBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppStatusBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    AppStatusBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractualDateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractualDateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BloodBM_ItemID = table.Column<int>(type: "int", nullable: true),
                    BloodBM_ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfPostingBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    PlaceOfPostingBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessForLPR = table.Column<bool>(type: "bit", nullable: false),
                    LPRPaymentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportToHR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReportToHR_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFileLocationBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    EmployeeFileLocationBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryAccountAcc_BankID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SalaryAccountAcc_BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalarySheetSerialNo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GenderBM_ItemID = table.Column<int>(type: "int", nullable: true),
                    GenderBM_ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    SalaryScaleBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    SalaryScaleBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureNameForWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfPostingPrefixForEmpCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DottedLineHR_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DottedLineHR_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLevelBM_ItemIDUsers = table.Column<int>(type: "int", nullable: true),
                    JobLevelBM_ItemNameUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalEntityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_LegalEntityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_InterCompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_OU_ID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EBS_OU_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_CostCenterID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EBS_CostCenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_CostCenterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_LocationID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EBS_LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_Region_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EBS_Depot_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoldSalary = table.Column<bool>(type: "bit", nullable: true),
                    HoldSalaryReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HR_BandID = table.Column<int>(type: "int", nullable: true),
                    BandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HR_GradeID = table.Column<int>(type: "int", nullable: true),
                    GradeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportTo2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReportTo2_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DottedLine2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DottedLine2_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalReportTo1_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdditionalReportTo1_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalReportTo2_EmployeeID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdditionalReportTo2_EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RoleID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<int>(type: "int", nullable: true),
                    HRMappedRoleId = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MappedRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRRoleId = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sap_bu_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sap_func_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sap_subFunc_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sap_area_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sap_subArea_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sap_support_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateBy = table.Column<long>(type: "bigint", nullable: true),
                    LastUpdateByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
