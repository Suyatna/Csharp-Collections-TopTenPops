using System;
using System.Collections.Generic;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath =
                @"G:\Pluralsight\C# Development Fundamentals\1. Beginner\2. Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country liliput = new Country("liliput", "LIL", "Somewhere", 2_000_000);

            int liliputIndex;
            countries.Insert(1, liliput);

            foreach (Country country in countries)
            {
                Console.WriteLine(
                    $"{PopulationFormatting.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
