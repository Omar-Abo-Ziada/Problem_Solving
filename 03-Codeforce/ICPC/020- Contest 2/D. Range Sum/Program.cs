namespace D._Range_Sum
{
    internal struct Range
    {
        internal long First;
        internal long Last;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
             D. Range Sum
time limit per test1 second
memory limit per test256 megabytes
You are given a range represented by two integers L
 and R
, and you should find the sum of the numbers in the range between L
 and R
 inclusive.

Input
First line contains a number T
 (1≤T≤105
) – the number of test cases.

Each of the next T
 lines contains two numbers L,R
 (1≤L,R≤109
).

Output
For each test case, prlong the sum.

Example
InputCopy
4
3 6
2 11
4 16
7 17
OutputCopy
18
65
130
132


             */
            #endregion

            int T = int.Parse(Console.ReadLine());

            long[] results = new long[T];

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split();

                long L = long.Parse(input[0]);
                long R = long.Parse(input[1]);

                results[i] = SumOfRange(L, R);
            }

            foreach (long result in results)
            {
                Console.WriteLine(result);
            }
        }

        static long SumOfRange(long L, long R)
        {
            long max = Math.Max(L, R);
            long min = Math.Min(L, R);

            long sumMinRange = (min * (min + 1) / 2) - min;
            long sumMaxRange = max * (max + 1) / 2;

            long result = sumMaxRange - sumMinRange ;

            return result;
        }
    }
}