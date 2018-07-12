using System.Collections.Generic;
using System.Threading.Tasks;
using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Interfaces.Repositories
{
    public interface IRepository<T, in TId> where T : AggregateRoot<TId>
    {
        T Get(TId id);
        IEnumerable<T> GetAll();
        Task SaveAsync();
    }
}