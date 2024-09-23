namespace TestGridSelectFile.Extensions
{
    public class ResponseResult<T> where T : class
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalItemCount { get; set; }
    }
}
