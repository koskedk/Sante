using System;
using System.Linq;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;

namespace Sante.SharedKernel.Infrastructure.Tests.Data.Repository
{
    [TestFixture]
    public class BaseRepositoryTests
    {
        private TestCountryRepository _countryRepository;
        [SetUp]
        public void SetUp()
        {
            _countryRepository = TestInitializer.ServiceProvider.GetService<TestCountryRepository>();
        }

        [Test]
        public void should_Get_By_Id()
        {
            var id = TestInitializer.TestCountries.First().Id;

            var testCountry = _countryRepository.Get(id);
            Assert.NotNull(testCountry);
            Console.WriteLine(testCountry);
        }
        [Test]
        public void should_Get_All()
        {
            var testCountries = _countryRepository.GetAll().ToList();
            Assert.True(testCountries.Any());
            foreach (var testCountry in testCountries)
            {
                Console.WriteLine(testCountry);
            }
        }
    }
}