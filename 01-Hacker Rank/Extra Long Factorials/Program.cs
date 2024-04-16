using System.Numerics;

namespace Extra_Long_Factorials
{
    internal class Program
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger sum = 1;
            for (int i = 0; i < n - 1; i++)
            {
                sum *= (n - 1 - i);
            }
            Console.WriteLine(sum * n);

        }
        static void Main(string[] args)
        {
        }
    }
}
