using System;
using System.IO;

namespace TopTenPops
{
	public class CsvReader
	{
		private string csvReader;

		public CsvReader(string csvReader)
		{
			this.csvReader = csvReader;
		}

		public Country[] ReadFirstNCountries(int nCountries)
		{
			Country[] countries = new Country[nCountries];

			using (StreamReader stream = new StreamReader(csvReader))
			{
				stream.ReadLine();

				for (int i = 0; i < nCountries; i++)
				{
					string csvLine = stream.ReadLine();
					countries[i] = ReadCountryFromCsvLine(csvLine);
				}
			}

				return countries;
		}

		public Country ReadCountryFromCsvLine(string csvLine)
		{
			string[] parts = csvLine.Split(new char[] { ',' });

			string name = parts[0];
			string code = parts[1];
			string region = parts[2];
			int population = int.Parse(parts[3]);

			return new Country(name, code, region, population);
		}
	}
}
