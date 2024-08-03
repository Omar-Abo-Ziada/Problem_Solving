using System.Text;

namespace P._Shape1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*P. Shape1
   time limit per test1 second
   memory limit per test256 megabytes
   Given a number N. Print a face down right angled triangle that has N rows.

   For more clarification see the example below.

   Input
   Only one line containing a number N (1 ≤ N ≤ 99).

   Output
   Print the answer according to the required above.

   Example
   InputCopy
   4
   OutputCopy
   ****
   ***
   **
   *
   Note
   Don't print any extra spaces after symbol " * ".

   */
            #endregion


            short n = short.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                PrintSymbols(i);
            }
        }

        internal static void PrintSymbols(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb);
        }
    }
}