using Sante.SharedKernel.Model;

namespace Sante.SharedKernel.Infrastructure.Tests
{
    public class TestCountry:AggregateRoot<string>
    {
        public string Name { get; set; }

        public TestCountry()
        {
        }

        public TestCountry(string id,string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}";
        }
    }
}