using System;

namespace C_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            int result = string.Compare(X, Y);

            if (result < 0)
            {
                Console.WriteLine(X);
            }
            else if (result > 0)
            {
                Console.WriteLine(Y);
            }
            else
            {
                Console.WriteLine(X);
            }
        }
    }
}
