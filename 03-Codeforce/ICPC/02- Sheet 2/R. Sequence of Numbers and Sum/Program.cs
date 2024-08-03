using System;

namespace R._Sequence_of_Numbers_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*R. Sequence of Numbers and Sum
            time limit per test1 second
            memory limit per test256 megabytes
            Given multiple lines each line contains two numbers N and M.
            
            For each line print a single line contains:
            
            The numbers between N and M inclusive separated by single space.
            The message " sum =".
            The summation of all numbers between N and M inclusive.
            Note: The program should be TERMINATED as soon as any of these two numbers is less than or equal to zero and don't print any thing.
            
            For more clarification see the examples below.
            
            Input
            The input contains multiple line.
            
            Each line contains two numbers N and M (-100 ≤ N, M ≤ 100).
            
            It's guaranteed that the last line of the input will contain a number that is less than or equal to zero.
            
            Output
            For each line print the answer according to the required above in a single line.
            
            Examples
            InputCopy
            5 2
            5 7
            5 -1
            OutputCopy
            2 3 4 5 sum =14
            5 6 7 sum =18
            InputCopy
            5 2
            6 3
            5 0
            OutputCopy
            2 3 4 5 sum =14
            3 4 5 6 sum =18
            Note
            M may be greater than N and Vice Versa.
            */
            #endregion

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] parts = line.Split();
                int N = int.Parse(parts[0]);
                int M = int.Parse(parts[1]);

                if (N <= 0 || M <= 0)
                {
                    break;
                }

                PrintSum(N, M);
            }
        }

        internal static void PrintSum(int N, int M)
        {
            if (N > M)
            {
                int temp = N;
                N = M;
                M = temp;
            }

            int sum = 0;

            for (int i = N; i <= M; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }

            Console.WriteLine($"sum = {sum}");
        }
    }
}
