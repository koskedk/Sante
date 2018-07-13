using System;
using System.Collections.Generic;

namespace Sante.SharedKernel.Model.Common
{
    public class Address: ValueObject<Address>
    {
        public string Area { get; }
        public string City { get; }
        public string Country { get; }

        public Address(string area, string city, string country)
        {
            Area = area;
            City = city;
            Country = country;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Area;
            yield return City;
            yield return Country;
        }
    }
}