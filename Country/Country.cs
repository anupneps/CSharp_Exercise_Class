using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace CountryDetails
{
    public class Country
    {
        public string Name { get; init; }
        public int Population { get; set; }
        public string Region { get; init; }
        public string CapitalCity { get; init; }
        public int GDP { get; set; }

        public List<Language> Languages { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> NeighbouringCountries { get; set; }

        public Wealthiness WealthStatus => GetWealthStatus();

        public  Wealthiness GetWealthStatus()
        {
            if (GDP < 300)
            {
                return Wealthiness.Poor;
            }
            return Wealthiness.Unknown;
        }

        public bool AddLanguage(Language language)
        {
            if(Languages.Contains(language))
            {
                return false;
            }
            Languages.Add(language);
            return true;
        }

        public bool AddCities(List<City> cities)
        {
            Cities.AddRange(cities); return true;
        }
        
        public bool AddNeighbouringCountry(Country country)
        {
            if(NeighbouringCountries.Contains(country)) { return false; }
            NeighbouringCountries.Add(country);
            return true;
        }
        
        public bool HasBorder(Country country)
        {
            if (NeighbouringCountries.Contains(country)) { return true; }
            return false;
        }

        public bool HasBorder(string countryName)
        {
           foreach(var country in NeighbouringCountries)
            {
                if (countryName == country.Name)
                    return true;
            }
            return false;
        }


        public Country(string name, int population, string region, string capital, int gdp)
        {
            Name = name;
            Population = population;
            Region = region;
            CapitalCity = capital;
            GDP = gdp;
            Languages = new List<Language>();
            Cities = new List<City>();
            NeighbouringCountries= new List<Country>();
        }

        
    }
}
