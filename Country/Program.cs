using System;
using CountryDetails;

//var languages = new List<Language>();
//languages.Add(new Language("Nepali", true));

var cities = new List<City>();
cities.Add(new City("Helsinki", 1, true));
cities.Add(new City("Espoo", 2, true));


var nepal = new Country("Nepal", 3, "Asia", "katmandu", 280);
nepal.AddLanguage(new Language("Nepali"));
nepal.AddLanguage(new Language("Bhojpuri"));
nepal.AddCities(cities);
nepal.AddNeighbouringCountry(new Country("China", 100, "Asia", "Beijing", 1000));
Console.WriteLine($"Country Details \n Name : {nepal.Name} \n Population: {nepal.Population} mil \n Capital: {nepal.CapitalCity}");

nepal.WealthStatus.ToString();

Wealthiness wealth = Wealthiness.Poor;
Console.WriteLine(nepal.WealthStatus.ToString());


