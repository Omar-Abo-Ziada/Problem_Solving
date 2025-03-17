using System;
using System.Linq;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            var result = LongestCommonPrefix(strs);
            Console.WriteLine(result); // Output: "fl"


            string[] strs2 = { "afflower", "gssflowf", "fflflaight" };
            var result2 = LongestCommonPrefix(strs);
            Console.WriteLine(result2); // Output: "fl"
        }

        static public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;

            string commonPrefix = strs[0];

            for(int i = 0; i < strs.Length; i++)
            {
                string currentString = strs[i];

                while (currentString.IndexOf(commonPrefix) != 0)
                {
                    commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);

                    if (commonPrefix.Length == 0)
                        return string.Empty;
                }
            }

            return commonPrefix;
        }
    }
}
