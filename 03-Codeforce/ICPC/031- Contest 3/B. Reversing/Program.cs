using System.Reflection;

namespace B._Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*B. Reversing
      time limit per test1 second
      memory limit per test256 megabytes
      You are given an array a
       of n
       integers. we want to make some operations on it.

      The operation is at each element that is equal to Zero
       - starting from the beginning of the array-, reverse the order of all elements before it.

      What is the final order of this array?

      Input
      The first line contains an integer n
       (1≤n≤100)
       the number of the elemnnts in the array a
      .

      The second line contains n
       integers ai
       (0≤ai≤105)
       the elements of the array a
      .

      Output
      You have to print the n
       numbers after performing all operations (reversing) on it.

      Example
      InputCopy
      7
      1 2 0 4 0 5 6
      OutputCopy
      4 0 1 2 0 5 6 
      */ 
            #endregion

            int N = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(Console.ReadLine().Split() , int.Parse);

            for (int i = 0; i < N; i++)
            {
                if (nums[i] == 0)
                {
                    Reverse(0 , i , nums);
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{nums[i] }");

            }
        }

        private static void Reverse( int startIndex ,  int endEndex , int[] nums )
        {
            for (int i = startIndex; i < (endEndex+1)/2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[endEndex-i];
                nums[endEndex-i] = temp;
            }
        }
    }
}
