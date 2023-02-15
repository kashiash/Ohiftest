namespace ApiForTestOHIF
{
    public class PagedResult<T>
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="entity">The complete result set</param>
        /// <param name="pageNumber">The current page number for the <see cref="Result"/></param>
        /// <param name="pageSize">The size of the page</param>
        public PagedResult(IEnumerable<T> subEntity, int offset, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            Offset = offset;
            PageSize = pageSize;
            Result = subEntity;

            PageNumber = (int)Math.Floor((decimal)(Offset / PageSize) + 1);
            NumberOfPages = (int)Math.Ceiling(((decimal)TotalCount / PageSize));
        }

        /// <summary>
        /// Gets the current page result
        /// </summary>
        public virtual IEnumerable<T> Result
        {
            get; private set;
        }

        /// <summary>
        /// Gets the current page number returned in the <see cref="Result"/>
        /// </summary>
        public int PageNumber { get; }

        /// <summary>
        /// Gets the total count of the result
        /// </summary>
        public virtual int TotalCount
        {
            get; private set;
        }

        /// <summary>
        /// Gets the page size
        /// </summary>
        public virtual int PageSize
        {
            get; private set;
        }

        /// <summary>
        /// Gets the current offset returned in the <see cref="Result"/>
        /// </summary>
        public virtual int Offset
        {
            get; private set;
        }

        /// <summary>
        /// Gets the complete number of pages availabile.
        /// </summary>
        public virtual int NumberOfPages
        {
            get; private set;
        }
    }
}
