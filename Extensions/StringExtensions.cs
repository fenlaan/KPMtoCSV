using System;
using System.Text.RegularExpressions;

namespace KPMToCSV.Extensions
{
    public static class StringExtensions
    {
        public static string MatchRemoveAndTrim(this string sourceString, string removeString)
        {
            if (string.IsNullOrEmpty(sourceString))
            {
                throw new Exception("Invalid Line");//If this happens the format of the file changed.
            }
            
            var rgx = new Regex(removeString);
            var result = rgx.Replace(sourceString, "", 1);
            if (result.Equals(sourceString))
            {
                throw new Exception("Invalid Line");//If this happens the format of the file changed.
            }
            return result.Trim();
        }
    }
}
