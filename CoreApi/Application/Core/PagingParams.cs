namespace QMS_API.Application.Core
{
    public class PagingParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }

    //public class TestParams : PagingParams
    //{
    //    public int Skip { get; set; }
    //    public int Take { get; set; }
    //    public string Filter { get; set; }
    //    public string CustomFilter { get; set; }
    //}
}
