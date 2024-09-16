using System;
using System.Collections.Generic;
using System.Text;

namespace L._String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int N = int.Parse(input[0]); // Size of the string
            int Q = int.Parse(input[1]); // Number of queries
            var S = new StringBuilder(Console.ReadLine()); // Initial string

            for (int i = 0; i < Q; i++)
            {
                var query = Console.ReadLine().Split();
                switch (query[0])
                {
                    case "pop_back":
                        if (S.Length > 0) S.Length--;
                        break;

                    case "front":
                        if (S.Length > 0) Console.WriteLine(S[0]);
                        break;

                    case "back":
                        if (S.Length > 0) Console.WriteLine(S[S.Length - 1]);
                        break;

                    case "sort":
                        int sortL = int.Parse(query[1]) - 1;
                        int sortR = int.Parse(query[2]);
                        var subStringSort = S.ToString(sortL, sortR - sortL);
                        char[] sortedChars = subStringSort.ToCharArray();
                        Array.Sort(sortedChars);
                        S.Remove(sortL, sortR - sortL);
                        S.Insert(sortL, new string(sortedChars));
                        break;

                    case "reverse":
                        int reverseL = int.Parse(query[1]) - 1;
                        int reverseR = int.Parse(query[2]);
                        var subStringReverse = S.ToString(reverseL, reverseR - reverseL);
                        char[] reversedChars = subStringReverse.ToCharArray();
                        Array.Reverse(reversedChars);
                        S.Remove(reverseL, reverseR - reverseL);
                        S.Insert(reverseL, new string(reversedChars));
                        break;

                    case "print":
                        int printPos = int.Parse(query[1]) - 1;
                        if (printPos >= 0 && printPos < S.Length) Console.WriteLine(S[printPos]);
                        break;

                    case "substr":
                        int substrL = int.Parse(query[1]) - 1;
                        int substrR = int.Parse(query[2]);
                        var subString = S.ToString(substrL, substrR - substrL);
                        Console.WriteLine(subString);
                        break;

                    case "push_back":
                        char pushChar = query[1][0];
                        S.Append(pushChar);
                        break;

                }
            }
        }
    }
}
