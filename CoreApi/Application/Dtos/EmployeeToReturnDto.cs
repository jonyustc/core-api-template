namespace CoreApi.Application.Dtos
{
    public class EmployeeToReturnDto
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
    }
}
