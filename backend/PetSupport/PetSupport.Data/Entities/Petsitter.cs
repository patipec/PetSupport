using System.Collections.Generic;

namespace PetSupport.Data.Entities
{
    public class Petsitter
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string Password;
        public string Photo;
        public string City;
        public List<Service> Services;
    }
}