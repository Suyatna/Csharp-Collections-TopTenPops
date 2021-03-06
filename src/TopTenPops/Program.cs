﻿using System;
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

            Dictionary<string, List<Country>> countries = reader.ReadAllCountries();

            foreach (string region in countries.Keys)
            {
                Console.WriteLine(region);
            }

            Console.WriteLine("\nWhich of the above regions do you want? ");
            Console.Write(">> ");
            string choosenRegion = Console.ReadLine();

            if (countries.ContainsKey(choosenRegion))
            {
                foreach (Country country in countries[choosenRegion].Take(10))
                {
                    Console.WriteLine(
                        $"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid region!");
            }

            // RemoveComma(reader, countries); 
            // FilterCountries();
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

        public void FilterCountries()
        {
            //var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(20);

            //var filteredCountries2 = from country in countries
            //                         where !country.Name.Contains(',')
            //                         select country;

            //foreach (Country country in filteredCountries2)
            //{
            //    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            //}

            //for (int i = 12; i <= 14; i++)
            //{
            //    Console.WriteLine(countries[i].Name);
            //}
        }
    }
}
