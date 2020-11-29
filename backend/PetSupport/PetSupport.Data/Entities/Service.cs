using System;
using System.Collections.Generic;
using System.Text;

namespace PetSupport.Data.Entities
{
    public class Service
    {
        public int Id;
        public string ImageId;
        public ServiceType Name;
        public string Description;
        public Unit Unit;
        public decimal Price;
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
