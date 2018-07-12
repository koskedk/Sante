using Sante.SharedKernel.Infrastructure.Data.Repository;

namespace Sante.SharedKernel.Infrastructure.Tests
{
    public class TestCountryRepository : BaseRepository<TestCountry, string>
    {
        public TestCountryRepository(TestDbContext context) : base(context)
        {
        }
    }
}