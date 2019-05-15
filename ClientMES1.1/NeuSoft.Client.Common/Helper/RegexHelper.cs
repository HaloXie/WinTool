using System.Text.RegularExpressions;

namespace NeuSoft.Client.Common.Helper
{
    public class RegexHelper
    {
        public static bool IsMatch(string inputString, string patternString)
        {
            return Regex.IsMatch(inputString, patternString);
        }

        public static bool IsTelephone(string inputString)
        {
            return IsMatch(inputString, @"");
        }
        public static bool IsNumber(string inputString)
        {
            return IsMatch(inputString, @"\d+");
        }
    }
}
