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
        public const int MaxPageSize = 20;

        [Required] public int PageNumber { get; set; } = 1;

        private int _pageSize = 20;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }
    }
}
