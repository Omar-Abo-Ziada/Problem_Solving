using System.Numerics;

namespace H._Simple_Mod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*

            H. Simple Mod
time limit per test1 second
memory limit per test256 megabytes
Hady has a positive number N
and a simple equation:

(X2+Y2)
MOD N=0
Your task is to find any values for X,Y
that satisfy the equation, such that X
and Y
are non-negative integers.

Input
Only one integer N
(1≤N≤10100
).

Output
If you can find any two non-negative integers such that (X,Y≤109
), print them. Otherwise, print "No solutions".

Examples
InputCopy
5
OutputCopy
4 3
InputCopy
100000100
OutputCopy
10 10000
InputCopy
50
OutputCopy
5 5
           */
            #endregion

            BigInteger N = BigInteger.Parse(Console.ReadLine());

            for (BigInteger x = 0; x <= 1000000000; x++)
            {
                BigInteger xSquared = x * x;
                BigInteger remainder = N - xSquared;

                if (remainder < 0)
                    continue;

                BigInteger y = BigInteger.ModPow(remainder, 1, N);

                if (y * y % N == remainder % N)
                {
                    Console.WriteLine($"{x} {y}");
                    return;
                }
            }

            Console.WriteLine("No solutions");

            //BigInteger N = BigInteger.Parse(Console.ReadLine());

            //for (in X = 0; X * X <= N ; X++)
            //{
            //    BigInteger squareX = X * X;

            //    BigInteger squareY = N - squareX;

            //    BigInteger Y = BigIntSqrt(squareY);

            //    if (Y == squareY)
            //    {
            //        Console.WriteLine($"{X} {Y}");
            //    }
            //}
        }

        //static BigInteger BigIntSqrt(BigInteger n)
        //{
        //    if (n == 0) return 0;
        //    BigInteger x = n / 2 + 1;
        //    BigInteger y = (x + n / x) / 2;
        //    while (y < x)
        //    {
        //        x = y;
        //        y = (x + n / x) / 2;
        //    }
        //    return x;
        //}

    }
}