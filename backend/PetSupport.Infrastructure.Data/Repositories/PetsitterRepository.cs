using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : IRepository<Petsitter>, IPetsitterRepository

    {
        internal readonly DataContext Context;
        internal DbSet<Petsitter> Petsitters;
        internal DbSet<PetsitterService> PetsitterServices;
        internal DbSet<Service> Services;


        public PetsitterRepository(DataContext context)

        {
            if (context == null) throw new ArgumentNullException("context");
            context = Context;
        }


        public async Task<Petsitter> GetByIdAsync(int id)
        {
            return await Petsitters.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await Petsitters.ToListAsync();
        }

        //Filters: string City, enum ServiceType Name, enum Unit Unit, dobule Price 
        //(string city, int serviceId, Unit unit, double minPrice, double maxPrice)


        public async Task<List<Petsitter>> FindByConditionAsync(
            Expression<Func<Petsitter, bool>> expression)
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            var result = await Petsitters.Where(expression).ToListAsync();
            return result;
        }

        // public Expression<Func<Petsitter, bool>> GetExpression(
        //     double minPrice, double maxPrice, string city,
        //     int serviceId)
        // {
        //     // ParameterExpression cityp = Expression.Parameter(typeof(string), "city");
        //     // ParameterExpression price1 = Expression.Parameter(typeof(int), "minPrice");
        //     // ParameterExpression price2 = Expression.Parameter(typeof(int), "maxPrice");
        //     // ParameterExpression service = Expression.Parameter(typeof(int), "serviceId");
        //
        //
        //     // var cityParam = new Func<Petsitter, bool>(Petsitters => Petsitters.City.Equals(city));
        //     // var serviceParam = new Func<PetsitterService, bool>(
        //     // PetsitterServices => this.PetsitterServices
        //     // var priceParam = new Func<Petsitter, bool>(Petsitter=> Petsitter.Services
        //     // .Contains(PetsitterServices));
        //
        //     var sameCity = Petsitters
        //         .Where(p => p.City == city);
        //     var sameId = PetsitterServices
        //         .Where(ps => ps.Id == serviceId);
        //     var priceRange = PetsitterServices
        //         .Where(ps => ps.Price > minPrice && ps.Price < maxPrice);
        //
        //
        //     // var expression = from p in Petsitters.Where(p => p.City = cityp)
        //     //     from ps in PetsitterServices
        //     //         .Where(ps => ps.ServiceId == serviceId
        //     //                      && ps.Price > minPrice && ps.Price < maxPrice)
        //     //     select new { Petsitters};
        //
        //
        // }


        public void Add(Petsitter entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            Petsitters.Add(entity);
            SaveChangesAsync();
        }

        public void Update(Petsitter entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            Petsitters.Update(entity);
            SaveChangesAsync();
        }

        public Task<bool> SaveChangesAsync()
        {
            return Task.FromResult(true);
        }

        public List<Petsitter> IsPetsitterWithSameCity(string city)
        {
            if (city == null) throw new ArgumentException("You have to put city");

            var sameCity = Petsitters.Where(p => p.City == city);
            return sameCity.ToList();
        }

        public IQueryable<PetsitterService> IsPetsitterInPriceRange(
            double minPrice, double maxPrice, int serviceId)
        {
            if (maxPrice == 0) throw new ArgumentException("Maximum price is set as 0");

            var sameService = PetsitterServices
                .Where(ps => ps.Service.Id == serviceId);
            var inPriceRange = sameService
                .Where(ps => ps.Price > minPrice && ps.Price < maxPrice);

            return inPriceRange;
        }
    }
}