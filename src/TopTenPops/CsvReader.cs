using System;

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
			return countries;
		}
	}
}
