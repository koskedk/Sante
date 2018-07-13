using System;
using NUnit.Framework;
using Sante.SharedKernel.Custom;
using Sante.SharedKernel.Tests.TestArtifacts;

namespace Sante.SharedKernel.Tests.Model
{
    [TestFixture]
    public class TestAggregateRootTests
    {
        private TestAggregateRoot _testRoot;

        [SetUp]
        public void Setup()
        {
            _testRoot = new TestAggregateRoot("Home test");
        }

        [Test]
        public void should_have_a_LiveGuid()
        {
            Assert.False(_testRoot.Id.IsNullOrEmpty());
            Console.WriteLine(_testRoot);
        }
    }
}