using System.Text;

namespace T._Shape2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*T. Shape2
              time limit per test1 second
              memory limit per test256 megabytes
              Given a number N. Print a pyramid that has N rows.

              For more clarification see the example below.

              Input
              Only one line containing a number N (1 ≤ N ≤ 99).

              Output
              Print the answer according to the required above.

              Example
              InputCopy
              4
              OutputCopy
                 *
                ***
               *****
              *******
              Note
              Don't print any extra spaces after symbol " * ".

              */
            #endregion
            short n = short.Parse(Console.ReadLine());

            for (int i = 0; i< n; i++)
            {
                PrintSymbols(i ,n);
            }
        }

        internal static void PrintSymbols(int i , int n)
        {
            int spacesCount = n - i -1;

            for (int j = 1; j <= spacesCount; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= (i+i); j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}