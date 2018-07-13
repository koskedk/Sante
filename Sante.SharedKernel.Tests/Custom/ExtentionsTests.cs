using System;
using NUnit.Framework;
using Sante.SharedKernel.Custom;

namespace Sante.SharedKernel.Tests.Custom
{
    public class ExtentionsTests
    {
        [Test]
        public void should_check_Nullable_Guid_IsNullOrEmpty()
        {
            Guid? idA = null;
            Guid? idB = Guid.Empty;

            Assert.True(idA.IsNullOrEmpty());
            Assert.True(idB.IsNullOrEmpty());
        }

        [Test]
        public void should_check_Guid_IsNullOrEmpty()
        {
            Guid idA = Guid.Empty;
            Assert.True(idA.IsNullOrEmpty());
        }

        [Test]
        public void should_check_Nullable_Date_IsNullOrEmpty()
        {
            DateTime? dateTime = DateTime.MinValue;
            DateTime? dateTimeB = null;
            Assert.IsTrue(dateTime.IsNullOrEmpty());
            Assert.IsTrue(dateTimeB.IsNullOrEmpty());
        }

        [Test]
        public void should_check_Date_IsNullOrEmpty()
        {
            DateTime dateTime = DateTime.MinValue;
            Assert.IsTrue(dateTime.IsNullOrEmpty());
        }

        [Test]
        public void should_compare_Strings()
        {
            String first = "test";
            String second = "Test";
            string other = string.Empty;
            string nullString = null;

            Assert.True(first.IsSameAs(second));
            Assert.False(first.IsSameAs(other));
            Assert.False(nullString.IsSameAs(first));
        }
    }
}