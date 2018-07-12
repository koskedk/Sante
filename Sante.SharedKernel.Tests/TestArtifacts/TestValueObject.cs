using System.Collections.Generic;
using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Tests.TestArtifacts
{
    public class TestValueObject : ValueObject<TestValueObject>
    {
        public string Code { get; }
        public string Name { get; }

        public TestValueObject(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Code} {Name}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
            yield return Name;
        }
    }
}