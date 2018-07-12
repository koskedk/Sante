using Microsoft.EntityFrameworkCore;

namespace Sante.SharedKernel.Infrastructure.Data
{
    public abstract class BaseContext : DbContext
    {
        protected BaseContext(DbContextOptions options) : base(options)
        {
        }

        public virtual void EnsureSeeded()
        {
            
        }
    }
}
