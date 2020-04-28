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
            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if (gotCountry)
            {
                Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
            }
            else
            {
                Console.WriteLine($"Sorry, there is no country with code '{userInput}'");
            }
        }
    }
}
