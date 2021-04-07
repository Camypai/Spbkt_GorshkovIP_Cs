using System;
using System.Collections.Generic;
using System.Linq;


namespace Spbkt_GorshkovIP_Cs.Extensions
{
    public static class StringExtensions
    {
        public static IEnumerable<string> MyOwnSplit(this string str, char separate)
        {
            var result            = new List<string>();
            var lastSeparateIndex = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] != separate) continue;
                
                result.Add(str.Substring(lastSeparateIndex, i-lastSeparateIndex).Trim());
                lastSeparateIndex = i;
            }
            
            result.Add(str.Substring(lastSeparateIndex).Trim());

            return result;
        }

        public static bool IsPalindrome(this string str)
        {
            var str1 = str.ToLower().Replace(" ", "");
            var str2 = string.Join("",str1.Reverse());

            return str1.Equals(str2);
        }
    }
}