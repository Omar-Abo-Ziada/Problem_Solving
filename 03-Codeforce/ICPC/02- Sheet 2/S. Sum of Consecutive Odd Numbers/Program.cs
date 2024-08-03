namespace S._Sum_of_Consecutive_Odd_Numbers
{
    internal struct TestCase
    {
        internal int N;
        internal int M;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*S. Sum of Consecutive Odd Numbers
time limit per test1 second
memory limit per test256 megabytes
Given two numbers X and Y. Print the sum of all odd numbers between them, excluding X and Y.

Input
First line contains a number T (1 ≤ T ≤ 10) number of test cases.

Next T lines will contain two numbers X and Y (0 ≤ X, Y ≤ 104).

Output
Print the sum of all odd numbers between X and Y (excluding X and Y).

Example
InputCopy
3
5 6
10 4
4 9
OutputCopy
0
21
12
*/
            #endregion

            int numOfTestCases = int.Parse(Console.ReadLine());

            TestCase[] testCases = new TestCase[numOfTestCases];

            for (int i = 0; i < numOfTestCases; i++)
            {
                string[] parts = Console.ReadLine().Split();
                int N = int.Parse(parts[0]);
                int M = int.Parse(parts[1]);

                testCases[i].N = N; 
                testCases[i].M = M; 

                //if (N <= 0 || M <= 0)
                //{
                //    break;
                //}
            }

            for (int i = 0;i < numOfTestCases;i++)
            {
                PrintSumOddNums(testCases[i].N , testCases[i].M);
            }
        }

        internal static void PrintSumOddNums(int N, int M)
        {
            if (N > M)
            {
                int temp = N;
                N = M;
                M = temp;
            }

            int sum = 0;

            for (int i = N+1; i < M; i++)
            {
                if(i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"{sum}");
        }
    }
}