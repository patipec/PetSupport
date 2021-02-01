using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSupport.Core.ResourceParameters
{
    public class PagingParameters
    {
        //Pagination
        public const int MaxPageSize = 20;
        public int PageNumber { get; set; } = 1;

        private int _pageSize;

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
