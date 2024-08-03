using System.Text;

namespace Q._Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*Q. Digits
           time limit per test1 second
           memory limit per test256 megabytes
           Given a number N. Print the digits of that number from right to left separated by space.

           Input
           First line contains a number T (1 ≤ T ≤ 10) number of test cases.

           Next T lines will contain a number N (0 ≤ N ≤ 109)

           Output
           For each test case print a single line contains the digits of the number separated by space.

           Example
           InputCopy
           4
           121
           39
           123456
           1200
           OutputCopy
           1 2 1
           9 3
           6 5 4 3 2 1
           0 0 2 1
           */
            #endregion

            int n = int.Parse(Console.ReadLine());

            int[] numsArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                numsArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                PrintDigits(numsArr[i]);
            }


            //Console.WriteLine($"n : {n}");

            //foreach (var item in numsArr)
            //{
            //    Console.WriteLine(item);
            //}

        }

        internal static void PrintDigits(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder sb = new StringBuilder();

            while (num > 0)
            {
                int digit = num % 10;
                sb.Append(digit);
                num /= 10;
            }

            string result = sb.ToString().TrimEnd();

            Console.WriteLine(string.Join(" ", result.ToCharArray()));
        }
    }
}