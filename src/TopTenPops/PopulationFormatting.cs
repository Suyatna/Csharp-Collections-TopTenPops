using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenPops
{
    class PopulationFormatting
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
