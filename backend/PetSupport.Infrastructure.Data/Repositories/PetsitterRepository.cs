using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
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
        private DbSet<Petsitter> Petsitters; 

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
            throw new NotImplementedException();

        }

        public async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await Petsitters.ToListAsync();
        }

        //Filters: string City, enum ServiceType Name, enum Unit Unit, doble Price
        public Task<IEnumerable<Petsitter>> FindByConditionAsync(Expression<Func<Petsitter, bool>> expression)
        {
            throw new NotImplementedException();
        }
        //TODO: TEST below
        public virtual async Task<IEnumerable<Petsitter>> GetFilteredAsync(
            Expression<Func<Petsitter, bool>> filter = null,
            Func<IQueryable<Petsitter>, IOrderedQueryable<Petsitter>> orderBy = null,
            string includeProperties = "",
            int first = 0, int offset = 0)
        {
            IQueryable<Petsitter> query = Petsitters;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (offset > 0)
            {
                query = query.Skip(offset);
            }

            if (first > 0)
            {
                query = query.Take(first);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }


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