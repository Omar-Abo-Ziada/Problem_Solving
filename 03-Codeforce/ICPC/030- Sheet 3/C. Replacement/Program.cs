namespace C._Replacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
               * C. Replacement
  time limit per test1 second
  memory limit per test256 megabytes
  Given a number N and an array A of N numbers. Print the array after doing the following operations:

  Replace every positive number by 1.
  Replace every negative number by 2.
  Input
  First line contains a number N (2 ≤ N ≤ 1000) number of elements.

  Second line contains N numbers (-105  ≤  Ai  ≤  105).

  Output
  Print the array after the replacement and it's values separated by space.

  Example
  InputCopy
  5
  1 -2 0 3 4
  OutputCopy
  1 2 0 1 1 

               */
            #endregion

            short n = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);

                if (nums[i] > 0)
                {
                    Console.Write($"{1} ");
                }
                else if (nums[i] < 0)
                {
                    Console.Write($"{2} ");
                }
                else
                {
                    Console.Write($"{nums[i]} ");
                }
            }



        }
    }
}
