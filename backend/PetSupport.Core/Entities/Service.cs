using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class Service : BaseEntity
    {
        public ServiceType Name { get; set; }
        public Unit Unit { get; set; }
    }
}