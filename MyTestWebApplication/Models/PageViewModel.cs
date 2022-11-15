namespace MyTestWebApplication.Models
{
    public class PageViewModel
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; }
        public bool HasPreviousPage => FirstPageRecord != 1;
        public bool HasNextPage => FirstPageRecord + PageSize <= TotalRecords;

        public int FirstPageRecord { get; }
        public int TotalRecords { get; }

        public IEnumerable<Record> Records { get; }
        public IEnumerable<int> AllPageSizes { get; } 
        public int PageSize { get; }

        public PageViewModel(int totalRecords, int pageSize, int firstPageRecord, IEnumerable<Record> records, IEnumerable<int> allPageSizes)
        {
            TotalRecords = totalRecords;
            PageSize = pageSize;

            TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            PageNumber = (int)Math.Ceiling(firstPageRecord / (double)pageSize); ;

            Records = records;
            AllPageSizes = allPageSizes;
            FirstPageRecord = firstPageRecord;
        }
    }
}
