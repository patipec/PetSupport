using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DynamicExpressions.Linq;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Petsitter>> FindByConditionAsync(Expression<Func<Petsitter, bool>> expression)
        {
            return await Petsitters.Where(expression).ToListAsync();

            
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


    }
}