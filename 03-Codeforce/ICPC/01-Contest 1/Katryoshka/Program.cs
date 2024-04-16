using System.Net.NetworkInformation;
using System;

namespace Katryoshka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //    a nice Katryoshka using one of the following combinations:

            //    Two eyes and one body.
            //    Two eyes, one mouth, and one body.
            //            One eye, one mouth, and one body.
            //If the king has n
            // eyes, m
            // mouths and k
            // bodies, what is the largest number of Katryoshkas he can make?
            //Input
            //Only one line containing three numbers n
            //, m
            // and k
            // (0≤n,m,k≤1018
            //) – the number of eyes, mouths and bodies respectively.

            //Output
            //Print the largest number of Katryoshkas he can make.

            //Examples
            //inputCopy
            //1 2 3
            //outputCopy
            //1
            //inputCopy
            //0 11 2
            //outputCopy
            //0
            //inputCopy
            //90 24 89
            //outputCopy
            //57 
            #endregion

            string[] inputs = Console.ReadLine().Split();

            long n = long.Parse(inputs[0]);
            long m = long.Parse(inputs[1]);
            long k = long.Parse(inputs[2]);

            long max ;

            if(n == 0 || k == 0)
            {
                max = 0;
            }
            else
            {
                long min = Math.Min(Math.Min(n , m) , k);

                n -= min;
                m -= min;
                k -= min;
                // one of them is zero now
                max = min;

                if (n == 0 || k == 0) 
                {
                    max = min;
                }
                else
                {
                    max += Math.Min(n / 2, k);
                }
            }

            Console.WriteLine(max);

            //===========================

            //wrong trai 

            //long max, max1, max2, max3;

            //max1 = Math.Min(n / 2, k);

            //max2 = Math.Min(n / 2, Math.Min(k, m));

            //max3 = Math.Min(n, Math.Min(m, k));

            //max = Math.Max(max1, Math.Max(max2, max3));

            //Console.WriteLine(max);

            //===========================

            //wrong trail 

            //if (n % 2 == 0 && k != 0)
            //{
            //    if (m == 0)
            //    {
            //        max = 2 * n + k;
            //    }

            //    if (m != 0)
            //    {
            //        long max1 = 2 * n + m + k;
            //        long max2 = n + m + k;

            //        max = Math.Max(max1, max2);
            //    }
            //}
            //else if (n % 2 != 0 && k != 0)
            //{
            //    if (m != 0)
            //    {
            //        long max1 = 2 * n + m + k;
            //        long max2 = n + m + k;

            //        max = Math.Max(max1, max2);
            //    }

            //    if (m == 0)
            //    {
            //        max = 2 * n + k;
            //    }
            //}
            //else if (k == 0)
            //{
            //    max = 0;
            //}

        }
    }
}
