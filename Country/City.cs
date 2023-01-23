using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDetails
{
    public class City
    {
        public string Name { get; init; }
        public int Population { get; init; }
        public bool IsCapital { get; set; }

        public City(string name, int population, bool isCapital = false) { 
            Name= name;
            Population= population;
            IsCapital = isCapital;
        }
    

    }
}
