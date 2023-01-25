using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace CountryDetails
{
    public class Country
    {
        /* provide your code for challenge 1 here */
        public string Name { get; init; }
        public int Population { get; set; }
        public string Region { get; init; }
        public string CapitalCity { get; init; }
        public double GDP { get; set; }
        public List<Language> Languages { get; set; }
        public City[] Cities { get; set; } = new City[20];
        public List<Country> NeighbouringCountries { get; set; }
        public Wealthiness WealthStatus => CheckWealth();
        public int counter = 0;

        public Country(string name, int population, string region, string capital, double gdp)
        {
            Name = name;
            Population = population;
            Region = region;
            CapitalCity = capital;
            GDP = gdp;
            Languages = new List<Language>();
            Cities = new City[20];
            NeighbouringCountries = new List<Country>();
            counter = 0;
        }

        public void PrintCities(City[] cities)
        {
            foreach (City city in cities)
            {
                if (city != null)
                    Console.WriteLine(city?.Name);
            }
        }
        public void PrintCities()
        {
            foreach (City city in Cities)
            {
                if (city != null)
                    Console.WriteLine(city?.Name);
            }
        }

        public City this[Index index]
        {
            get => Cities[index];
            set => Cities[index] = value;
        }
        public City[] this[Range range]
        {
            get => Cities[range];
        }

        public Wealthiness CheckWealth()
        {
            switch (GDP)
            {
                case > 30:
                    return Wealthiness.SuperRich;
                   
                case > 20:
                    return Wealthiness.Rich;
                   
                case > 10:
                    return Wealthiness.Medium;
                   
                case > 5:
                    return Wealthiness.Poor;
                   
                case < 5:
                    return Wealthiness.SuperPoor;
                  
                default:
                    return Wealthiness.Unknown;
                  
            }
        }
        public bool AddLanguage(Language language)
        {
            if (Languages.Contains(language))
            {
                return false;
            }
            Languages.Add(language);
            return true;
        }
        public bool AddCities(City cities)
        {
            //Cities.AddRange(cities); return true;
            Cities[counter] = cities;
            counter++;
            return true;
        }
        public bool AddNeighbouringCountry(Country country)
        {
            if (NeighbouringCountries.Contains(country)) { return false; }
            NeighbouringCountries.Add(country);
            return true;
        }

        public bool HasBorderWith(Country country)
        {
            foreach (var countryName in NeighbouringCountries)
            {
                if (countryName.Name == country.Name) { return true; }
            }
            return false;
        }

        public void printNeighbour()
        {
            foreach (var country in NeighbouringCountries)
            {
                Console.WriteLine(country.Name.ToString());
            }
        }

        public bool HasBorderWith(string countryName)
        {
            foreach (var country in NeighbouringCountries)
            {
                if (countryName == country.Name)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return ($"Country Details \n Name : {Name} \n Population: {Population} mil \n Capital: {CapitalCity} \n GDP(%):{GDP}");
        }

    }
    
}
