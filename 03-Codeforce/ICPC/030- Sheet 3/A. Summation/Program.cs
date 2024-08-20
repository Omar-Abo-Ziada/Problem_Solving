using System.Numerics;

namespace A._Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
               A. Summation
  time limit per test2 seconds
  memory limit per test64 megabytes
  Given a number N and an array A of N numbers. Print the absolute summation of these numbers.

  absolute value : means to remove any negative sign in front of a number .

  EX : |-5| = 5 , |7| = 7

  Input
  First line contains a number N (1 ≤ N ≤ 105) number of elements.

  Second line contains N numbers (-109  ≤  Ai  ≤  109).

  Output
  Print the absolute summation of these numbers.

  Examples
  InputCopy
  4
  7 2 1 3
  OutputCopy
  13
  InputCopy
  3
  -1 2 -3
  OutputCopy
  2
  Note
  Second Example :

  -1 + 2 + -3 = -2 and it absolute is 2 so the answer is 2.
               */ 
            #endregion

            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            BigInteger sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }

            if(sum < 0)
            {
                sum *= -1;
            }

            Console.WriteLine(sum);
        }
    }
}