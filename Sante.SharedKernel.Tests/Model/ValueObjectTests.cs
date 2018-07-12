using NUnit.Framework;
using Sante.SharedKernel.Tests.TestArtifacts;

namespace Sante.SharedKernel.Tests.Model
{
    [TestFixture]
    public class ValueObjectTests
    {

        [Test]
        public void should_check_ValueObject_equlity()
        {
            TestValueObject regionA = new TestValueObject("Ke", "Kenya");
            TestValueObject regionC = new TestValueObject("Ke", "Kenya");
            TestValueObject regionB = new TestValueObject("Zm", "Zambia");

            Assert.True(regionA.Equals(regionC));
            Assert.True(regionB != regionA);
        }
    }
}