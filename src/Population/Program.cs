using System;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"Popular Indicators/91aff299-f948-4300-b856-816274042579_Data.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
