using Microsoft.EntityFrameworkCore;

namespace Sante.SharedKernel.Infrastructure.Tests
{
    public class TestDbContext:DbContext
    {
        public DbSet<TestCountry> TestCountries { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }
    }
}