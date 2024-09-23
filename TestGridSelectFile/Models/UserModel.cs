namespace TestGridSelectFile.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Salary { get; set; }
    }

    public partial class SearchingInfo
    {
        public string SummaryField { get; set; } = "None";
        public string SortField { get; set; } = " CreatedDate";
        public string SortDirection { get; set; } = " asc";
        public int PageSize { get; set; } = 10;
        public int PageCount { get; set; }
        public int CurrentPageIndex { get; set; } = 1;
        public string SearchText { get; set; }
        public string FilterText { get; set; } = "";
        public string DynamicFilter { get; set; }
        public string SelectedTextProperty { get; set; }
        public string SelectedDateProperty { get; set; }
        public string SelectedFilterProperty { get; set; }
        public string SelectedFilterPropertyValue { get; set; }
        public Guid? ParentID { get; set; }
        public string DocumentCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ListType { get; set; }
        public bool IsAdvanceSearch { get; set; }
        public bool IsArchive { get; set; } = false;
        public int Skip { get; set; }
        public int Take { get; set; }
        public string Sort { get; set; }
        public string Filter { get; set; }

        public string SelectionMode { get; set; } = "single"; //single , multiple

        public string SelectedExportColumns { get; set; }
    }

    public class SortingInfo
    {
        //
        // Summary:
        //     The data field to be used for sorting.
        public string Selector { get; set; }
        //
        // Summary:
        //     A flag indicating whether data should be sorted in a descending order.
        public bool Desc { get; set; }
    }
}
