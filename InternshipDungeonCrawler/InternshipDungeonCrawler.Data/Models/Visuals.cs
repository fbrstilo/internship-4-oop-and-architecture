using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Data.Models
{
    public static class Visuals
    {
        public static string ProgressBar(int value, int maxValue)
        {
            int i;
            var barLength = (10*value)/maxValue;
            var returnString = "";
            returnString += "[";
            for (i = 0; i < barLength; i++)
            {
                returnString += "X";
            }
            for (; i < 10; i++)
            {
                returnString += "-";
            }
            returnString += "]";
            return returnString;
        }
    }
}
