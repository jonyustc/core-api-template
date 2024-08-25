using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QMS_API.Application.Core
{
    public class Pagination
    {
        public Pagination(int pageIndex, int pageSize, int count, int pages)
        {
            CurrentPage = pageIndex;
            ItemsPerPage = pageSize;
            TotalItems = count;
            TotalPages = pages;
        }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
    }
}
