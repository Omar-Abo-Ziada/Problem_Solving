using System;

namespace M._Subsequence_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string target = "hello";

            if (IsSubsequence(input, target))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        // Function to check if target is a subsequence of input
        static bool IsSubsequence(string input, string target)
        {
            int targetIndex = 0;
            int targetLength = target.Length;

            // Iterate through the input string
            foreach (char ch in input)
            {
                if (ch == target[targetIndex])
                {
                    targetIndex++;
                    // If we have matched the whole target
                    if (targetIndex == targetLength)
                    {
                        return true;
                    }
                }
            }

            // If we finish the loop without fully matching target
            return false;
        }
    }
}
