using System;
using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Tests.TestArtifacts
{
    public class TestEntity:Entity<Guid>
    {
        public string Name { get; set; }

        public TestEntity(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}