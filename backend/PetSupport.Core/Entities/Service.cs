using System;
using System.Collections.Generic;
using System.Text;

namespace PetSupport.Data.Entities
{
    public class Service: BaseEntity
    {
        public int Id { get; set; }
        public string ImageId { get; set; }
        public ServiceType Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }
        public decimal Price { get; set; }
    }

    public enum Unit
    {
        Day,
        Hour,
        Night
    }

    public enum ServiceType
    {
        Boarding,
        HouseSitting,
        DogWalking,
        DropInVisit,
        DoggyDayCare
    }
}
