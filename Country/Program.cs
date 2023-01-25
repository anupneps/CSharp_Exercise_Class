using System;
using CountryDetails;

class Program
{
    private static void Main(string[] args)
    {
        //Challenge 1
        /* create variables from these countries
        Finland: 
        - Name: Finland
        - Population: 5530719
        - Region: Europe,
        - Capital: Helsinki
        - GDP: 27.3
        - Languages: Finnish, Swedish
        - Cities: Helsinki, Tampere, Lahti, Porvo, Kemi
        - Borders: Norway, Sweden, Russia
         */
        var Finland = new Country("Finland", 5530719, "Europe", "Helsinki", 27.3);
        var Sweden = new Country("Sweden", 10327589, "Europe", "Stockholm", 35.7);

        Console.WriteLine(Finland);

        Finland.AddNeighbouringCountry(Sweden);
        Finland.AddNeighbouringCountry(new Country("Norway", 5425270, "Europe", "Oslo", 30.7));
        Finland.AddNeighbouringCountry(new Country("Russia", 147182123, "Europe", "Moscow", 10.7));

        Finland.AddLanguage(new Language("Finnish"));
        Finland.AddLanguage(new Language("Swedish"));

        //Finland.printNeighbour();

        Finland.HasBorderWith("Sweden"); // returns true 
        Finland.HasBorderWith(Sweden); // returns true

        Finland[0] = new City("Helsinki", 1305893, true);
        Finland[1] = new City("Tampere", 341696, false);
        Finland[2] = new City("Lahti", 119469, false);
        Finland[3] = new City("Porvo", 50610, false);
        Finland[^1] = new City("Kemi", 26176, false);

        //Finland.PrintCities();
        var wealthiness = Finland.CheckWealth();
        Console.WriteLine(wealthiness);

        //Country.HasBorder(Finland);
        //Country.HasBorder("Finland");
        //Country.CheckWealth(Finland);

        var FinCities = Finland[0..2];
        var FirstCity = Finland[0];
        /* methods to print FinCities and FirstCity */
        Finland.PrintCities(FinCities);
        Console.WriteLine(FirstCity.Name);

        Console.ReadLine();

        //Challenge 2
        /* write your own game */
    }
}