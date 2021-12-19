namespace PetSupport.Core.ResourceParameters
{
    public class PagingParameters
    {
        //Pagination
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public PagingParameters()
        {
            this.PageNumber = 1;
            this.PageSize = 20;
        }

        public PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 20 ? 20 : pageSize;
        }
    }
}