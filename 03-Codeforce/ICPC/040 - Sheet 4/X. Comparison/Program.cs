using System;

namespace X.Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int n = S.Length;

            if (n == 1)
            {
                Console.WriteLine(S);
                return;
            }

            string smallestString = S; // Initially, assume the original string is the smallest

            for (int i = 1; i < n; i++)
            {
                string X = S.Substring(0, i);    // From start to i-1
                string Y = S.Substring(i);       // From i to end

                char[] xChars = X.ToCharArray();
                char[] yChars = Y.ToCharArray();
                Array.Sort(xChars);
                Array.Sort(yChars);

                string sortedX = new string(xChars);
                string sortedY = new string(yChars);
                string concatenated = sortedX + sortedY;

                if (string.Compare(concatenated, smallestString) < 0)
                {
                    smallestString = concatenated;
                }
            }

            Console.WriteLine(smallestString);
        }
    }
}
