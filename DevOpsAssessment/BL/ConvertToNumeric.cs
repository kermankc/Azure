using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public static class ConvertToNumeric
    {
        public static IEnumerable<int> ToInt(this string @string, string seperator="/")
        {
            return SplitBySeperator(@string, seperator).Select(int.Parse);
        }


        public static IEnumerable<float> ToFloat(this string @string, string seperator="/")
        {
            return SplitBySeperator(@string, seperator).Select(float.Parse);
        }
        private static string[] SplitBySeperator(string @string, string seperator)
        {
            return @string.Split(seperator);
        }
    }
}