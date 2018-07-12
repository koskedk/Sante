using System;
using System.Collections.Generic;
using System.Linq;
using FizzWare.NBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Sante.SharedKernel.Custom;

namespace Sante.SharedKernel.Infrastructure.Tests
{
    [SetUpFixture]
    public class TestInitializer
    {
        public static IServiceProvider ServiceProvider;
        public static List<TestCountry> TestCountries;

        [OneTimeSetUp]
        public void Setup()
        {
            TestCountries = Builder<TestCountry>.CreateListOfSize(2).Build().ToList();

            ServiceProvider = new ServiceCollection()
                .AddDbContext<TestDbContext>(o => o.UseInMemoryDatabase(LiveGuid.NewGuid().ToString()))
                .AddTransient<TestCountryRepository>()
                .BuildServiceProvider();

            var settingsContext = ServiceProvider.GetService<TestDbContext>();
            settingsContext.TestCountries.AddRange(TestCountries);
            settingsContext.SaveChanges();
        }
    }
}