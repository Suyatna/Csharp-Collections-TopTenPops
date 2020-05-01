using System;
using System.Collections.Generic;
using System.Linq;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Projects_C#\Csharp-Collections-TopTenPops\Csharp-Collections-TopTenPops\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            // RemoveComma(reader, countries);

            foreach (Country country in countries.Take(20).Where(x => !x.Name.Contains(',')))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }
        }

        public static void RemoveComma(CsvReader reader, List<Country> countries)
        {
            reader.RemoveCommaCountries(countries);

            Console.WriteLine("Enter no. of countries in a +ve integer. Existing");

            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Existing");
                return;
            }

            int maxToDisplay = userInput;
            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit>");
                    if (Console.ReadLine() != "") break;
                }

                Country country = countries[i];
                Console.WriteLine($"{i + 1} : {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }
        }
    }
}
