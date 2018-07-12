using System;
using NUnit.Framework;
using Sante.SharedKernel.Custom;
using Sante.SharedKernel.Tests.TestArtifacts;

namespace Sante.SharedKernel.Tests.Model
{
    [TestFixture]
    public class EntityTests
    {
        private TestEntity _testEntity;

        [SetUp]
        public void Setup()
        {
            _testEntity = new TestEntity("Subaru");
        }

        [Test]
        public void should_have_a_LiveGuid()
        {
            Assert.False(_testEntity.Id.IsNullOrEmpty());
            Console.WriteLine(_testEntity);
        }
    }
}