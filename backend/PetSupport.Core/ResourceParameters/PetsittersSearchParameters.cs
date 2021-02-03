using System;
using System.ComponentModel.DataAnnotations;

namespace PetSupport.Core.ResourceParameters
{
    public class PetsittersSearchParameters
    {
        //FindPetSitterShortFormDTO
        [Required]
        public string City { get; set; }
        [Required]
        public int ServiceId { get; set; }
        //FindPetSitterLongFormDTO
        public string Street { get; set; }
        public int? MinPrice { get; set; } = 0;
        public int? MaxPrice { get; set; } = Int32.MaxValue;

        //Pagination
        private const int MaxPageSize = 25;
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
                _pageSize = (value > MaxPageSize)? MaxPageSize: value;
            }
        }

    }
}