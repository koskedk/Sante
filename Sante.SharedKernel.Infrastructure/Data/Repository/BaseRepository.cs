using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sante.SharedKernel.Interfaces.Repositories;
using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Infrastructure.Data.Repository
{
    public  abstract class BaseRepository<T, TId>:IRepository<T, TId> where T : AggregateRoot<TId>
    {
        protected internal DbContext Context;
        protected internal DbSet<T> DbSet;

        protected BaseRepository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public T Get(TId id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsNoTracking();
        }

        public Task SaveAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}