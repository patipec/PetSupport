using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSupport.Core.ResourceParameters
{
    public class PagingParameters
    {
        //Pagination
        
        [Required] 
        public int PageNumber { get; set; }

        public int PageSize {get;set;}

        public PagingParameters()
        {
            this.PageNumber = 1;
            this.PageSize = 20;
        }
        public  PagingParameters(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 10 ? 10 : pageSize;
        }

    }

}
