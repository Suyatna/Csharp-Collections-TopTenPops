namespace TopTenPops
{
    class PopulationFormatter
    {
        public static string FormatPopulation(int population)
        {
            if (population == 0)
            {
                return "(Unknown)";
            }

            int popRounded = population;

            return $"{popRounded: ### ### ### ###}".Trim();
        }
    }
}
