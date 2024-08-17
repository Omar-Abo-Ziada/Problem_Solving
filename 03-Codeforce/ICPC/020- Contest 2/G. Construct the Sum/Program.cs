using System;
using System.Collections.Generic;

namespace G._Construct_the_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short numOfTestCases = short.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                int n = int.Parse(inputs[0]);
                long s = long.Parse(inputs[1]);

                List<int> results = ConstructSum(n, s);

                if (results == null)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(string.Join(" ", results));
                }
            }
        }

        private static List<int> ConstructSum(int n, long s)
        {
            List<int> results = new List<int>();
            long sum = 0;

            for (int i = n; i >= 1; i--)
            {
                if (sum + i <= s)
                {
                    sum += i;
                    results.Add(i);
                }

                if (sum == s)
                {
                    return results;
                }
            }

            return null;
        }
    }
}
