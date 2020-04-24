using System;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath =
                @"G:\Pluralsight\C# Development Fundamentals\1. Beginner\2. Beginning C# Collections\csharp-collections-beginning\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{country.Population} : {country.Name}");
            }
        }
    }
}
