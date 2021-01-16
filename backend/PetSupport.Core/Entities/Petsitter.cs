#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PetSupport.Core.Entities
{
    public class Petsitter : User
    {
        public string Description { get; set; }

        [Required] [NotNull] public string Password { get; set; }

        public string PhotoId { get; set; }

        [Required] public string? City { get; set; }

        [AllowNull] public string? Street { get; set; }

        [AllowNull] public string? ParcelAndHouseNumbers { get; set; }

        [AllowNull] public string? ZipCode { get; set; }

        [AllowNull] public double? Rate { get; set; }


        public List<PetsitterService> Services { get; set; }
    }
}