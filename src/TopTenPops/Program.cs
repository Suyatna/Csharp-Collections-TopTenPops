using System;
using System.Collections.Generic;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Projects_C#\Csharp-Collections-TopTenPops\Csharp-Collections-TopTenPops\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();

            for (int i = 0; i < countries.Count; i++)
            {
                Country country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }            
        }
    }
}
