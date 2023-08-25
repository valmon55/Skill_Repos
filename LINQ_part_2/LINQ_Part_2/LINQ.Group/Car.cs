using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Group
{
    class Car
    {
        public string Manufacturer;
        public string CountryCode;
        public Car(string name, string countryCode)
        {
            Manufacturer = name;
            CountryCode = countryCode;
        }
    }
}
