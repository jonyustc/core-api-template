using QMS_API.Persistence.Models;

namespace CoreApi.Persistence.Models
{
    public class Employee : BaseEntity
    {
        public long Id { get; set; }

        public decimal HR_EmployeeID { get; set; }

        public decimal? SF_ID { get; set; }

        public string HR_EmployeeName { get; set; }

        public int BM_BranchID { get; set; }

        public string BM_BranchName { get; set; }

        public string HR_DesgName { get; set; }

        public int? HR_DesgID { get; set; }

        public string HR_DeptName { get; set; }

        public int? HR_DeptID { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public int? NationalityInv_CountryID { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string MobileNo { get; set; }

        public string Mgr { get; set; }

        public bool? Inactive { get; set; }

        public string Email { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public DateTime? RetireDateApproximate { get; set; }

        public DateTime? RetireDateActual { get; set; }

        public string CauseOfSeparation { get; set; }

        public int? CauseOfSeparationBM_ItemID { get; set; }

        public DateTime? DateOfJoining { get; set; }

        public DateTime? ConfirmationDateApprox { get; set; }

        public int? MinimumDaysOfConfirmation { get; set; }

        public int? GrandeBM_ItemIDUsers { get; set; }

        public string GrandeBM_ItemNameUsers { get; set; }

        public int? AppStatusBM_ItemIDUsers { get; set; }

        public string AppStatusBM_ItemNameUsers { get; set; }

        public DateTime? ContractualDateFrom { get; set; }

        public DateTime? ContractualDateTo { get; set; }

        public int? BloodBM_ItemID { get; set; }

        public string BloodBM_ItemName { get; set; }

        public int? PlaceOfPostingBM_ItemIDUsers { get; set; }

        public string PlaceOfPostingBM_ItemNameUsers { get; set; }

        public bool ProcessForLPR { get; set; }

        public string LPRPaymentID { get; set; }

        public decimal? ReportToHR_EmployeeID { get; set; }

        public string ReportToHR_EmployeeName { get; set; }

        public int? EmployeeFileLocationBM_ItemIDUsers { get; set; }

        public string EmployeeFileLocationBM_ItemNameUsers { get; set; }

        public decimal? SalaryAccountAcc_BankID { get; set; }

        public string SalaryAccountAcc_BankName { get; set; }

        public string BankAccountNo { get; set; }

        public decimal? SalarySheetSerialNo { get; set; }

        public int? GenderBM_ItemID { get; set; }

        public string GenderBM_ItemName { get; set; }

        public int? DistrictBM_ItemIDUsers { get; set; }

        public int? SalaryScaleBM_ItemIDUsers { get; set; }

        public string SalaryScaleBM_ItemNameUsers { get; set; }

        public string Extension { get; set; }

        public string PictureNameForWeb { get; set; }

        public string PlaceOfPostingPrefixForEmpCode { get; set; }

        public decimal? DottedLineHR_EmployeeID { get; set; }

        public string DottedLineHR_EmployeeName { get; set; }

        public int? JobLevelBM_ItemIDUsers { get; set; }

        public string JobLevelBM_ItemNameUsers { get; set; }

        public string LegalEntityName { get; set; }

        public string EBS_LegalEntityCode { get; set; }

        public string EBS_InterCompanyCode { get; set; }

        public decimal? EBS_OU_ID { get; set; }

        public string EBS_OU_Name { get; set; }

        public decimal? EBS_CostCenterID { get; set; }

        public string EBS_CostCenterName { get; set; }

        public string EBS_CostCenterCode { get; set; }

        public string EBS_EmployeeCode { get; set; }

        public decimal? EBS_LocationID { get; set; }

        public string EBS_LocationName { get; set; }

        public string EBS_LocationCode { get; set; }

        public string EBS_Region_Code { get; set; }

        public string EBS_Depot_Code { get; set; }

        public string eTIN { get; set; }

        public bool? HoldSalary { get; set; }

        public string HoldSalaryReason { get; set; }

        public string Currency { get; set; }

        public int? HR_BandID { get; set; }

        public string BandName { get; set; }

        public int? HR_GradeID { get; set; }

        public string GradeName { get; set; }

        public decimal? ReportTo2_EmployeeID { get; set; }

        public string ReportTo2_EmployeeName { get; set; }

        public decimal? DottedLine2_EmployeeID { get; set; }

        public string DottedLine2_EmployeeName { get; set; }

        public decimal? AdditionalReportTo1_EmployeeID { get; set; }

        public string AdditionalReportTo1_EmployeeName { get; set; }

        public decimal? AdditionalReportTo2_EmployeeID { get; set; }

        public string AdditionalReportTo2_EmployeeName { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public decimal? RoleID { get; set; }

        public string RoleName { get; set; }

        public int? Position { get; set; }

        public decimal? HRMappedRoleId { get; set; }

        public string MappedRoleName { get; set; }

        public decimal? HRRoleId { get; set; }

        public string sap_bu_code { get; set; }

        public string sap_func_code { get; set; }

        public string sap_subFunc_code { get; set; }

        public string sap_area_code { get; set; }

        public string sap_subArea_code { get; set; }

        public string sap_support_code { get; set; }

    }
}
