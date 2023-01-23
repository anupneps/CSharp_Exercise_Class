using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDetails
{
    public class Language
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }

        public Language(string name, bool isDefault=false)
        {
            Name = name;
            IsDefault = isDefault;
        }

    }
}
