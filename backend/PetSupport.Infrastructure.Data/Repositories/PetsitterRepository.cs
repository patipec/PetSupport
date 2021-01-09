using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DynamicExpressions.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;


namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : IRepository<Petsitter>, IPetsitterRepository

    {
        internal readonly DataContext Context;
        internal DbSet<Petsitter> Petsitters;
        internal DbSet<Service> Services;
        internal DbSet<PetsitterService> PetsitterServices;

        
        public PetsitterRepository(DataContext context) 

        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            context = Context;
            
        }
        

        public  async Task<Petsitter> GetByIdAsync(int id)
        {
            return await Petsitters.FirstOrDefaultAsync(x=>x.Id == id);

        }

        public async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await Petsitters.ToListAsync();
        }

        //TODO: zapytać się jak to przerzutować
        public async Task<List<Petsitter>> FindByConditionAsync(
            Expression<Func<Petsitter, bool>> expression)
        {


            expression = GetExpression();

            return await new Task<List<Petsitter>>().ConfigureAwait(false);

        }

        public Expression<Func<Petsitter, bool>> GetExpression(
            double minPrice, double maxPrice, string city,
            int serviceId)
        {
            var expression = from p in Petsitters.Where(p => p.City == city)
                from ps in PetsitterServices
                    .Where(ps => ps.ServiceId == serviceId
                                 && ps.Price > minPrice && ps.Price < maxPrice)
                select new { Petsitters};
                
            return expression;
        }

        
        //Filters: string City, enum ServiceType Name, enum Unit Unit, dobule Price 
        //(string city, List<ServiceType> service, Unit unit, double Price)


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

        public IQueryable<Petsitter> IsPetsitterWithSameCity(string city)
        {
            if (city == null) throw new ArgumentException("You have to put city");
            
            var sameCity = Petsitters.Where(p => p.City == city);
            return sameCity;
        }

        public IQueryable<PetsitterService> IsPetsitterInPriceRange(
            double minPrice, double maxPrice, int serviceId)
        {
            if (maxPrice == 0) throw new ArgumentException("Maximum price is set as 0");
            
            var sameService = PetsitterServices
                .Where(ps=> ps.Service.Id == serviceId);
            var inPriceRange = sameService
                .Where(ps => ps.Price > minPrice && ps.Price < maxPrice);

            return inPriceRange;
        }

    }
}