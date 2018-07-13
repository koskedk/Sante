using System;
using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Tests.TestArtifacts
{
    public class TestAggregateRoot : AggregateRoot<Guid>
    {
        public string Name { get; set; }

        public TestAggregateRoot(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}