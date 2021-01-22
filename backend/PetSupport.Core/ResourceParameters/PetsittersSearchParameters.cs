using System;

namespace PetSupport.Core.ResourceParameters
{
    public class PetsittersSearchParameters
    {
        //FindPetSitterShortFormDTO
        public string City { get; set; }
        public int? ServiceId { get; set; } = null;
        
        //FindPetSitterLongFormDTO
        public string Street { get; set; }
        public int? MinPrice { get; set; } = 0;
        public int? MaxPrice { get; set; } = Int32.MaxValue;

        private const int maxPageSize = 25;
        public int pageNumber { get; set; } = 1;
        private int _pageSize;

        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize)? maxPageSize: value;
            }
        }

    }
}