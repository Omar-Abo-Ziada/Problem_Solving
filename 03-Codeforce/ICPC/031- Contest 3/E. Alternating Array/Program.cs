namespace E._Alternating_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*E. Alternating Array
   time limit per test1 second
   memory limit per test256 megabytes
   An array of integers is said to be alternating if each element has a different sign than the one next to it.

   i.e.
    for each element in the array such that (0≤i<n)
    , only one of these conditions must be met:-

   if ai<0
    then ai+1>0
   .
   if ai>0
    then ai+1<0
   .
   For example, [1, -3, 2] and [3] are alternating arrays, while [1,-3, -2] and [1, 2] are not.

   You are given an array a
    of n
    integers, in one operation, you are allowed to choose a number and multiply it by -1 (change its sign). what is the minimum number of operations required to convert the given array into an alternating array.

   Input
   The first line contains an integer n(1≤n≤105)
    the number of elements in the array a

   The second line contains n
    integers ai(−50≤ai≤50,ai≠0)
    the elements of the array a
   .

   Output
   Output the minimum number of operations needs to convert the given array into an alternative one.

   Examples
   InputCopy
   3
   3 4 2
   OutputCopy
   1
   InputCopy
   5
   1 -2 3 -4 5
   OutputCopy
   0
   */ 
            #endregion

            int N = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] numsCpy = new int[nums.Length];

             Array.Copy(nums,numsCpy,nums.Length);

            int minOpertaions = Math.Min(GetMin_AlternatingOperationsCountAlgorithm1(nums),GetMin_AlternatingOperationsCountAlgorithm2(numsCpy));

            Console.WriteLine(minOpertaions);

            //Console.WriteLine();

            //Console.WriteLine($"Algorithm 1 : {GetMin_AlternatingOperationsCountAlgorithm1(nums)}");


            //Console.WriteLine($"\n The Alternating Array aftert algorithm 1 :");

            //foreach (var item in nums)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine();

            //Console.WriteLine();

            //Console.WriteLine($"Algorithm 2 : {GetMin_AlternatingOperationsCountAlgorithm2(numsCpy)}");


            //Console.WriteLine($"\n The Alternating Array aftert algorithm 1 :");

            //foreach (var item in numsCpy)
            //{
            //    Console.Write($"{item} ");
            //}
        }

        private static int GetMin_AlternatingOperationsCountAlgorithm1(int[] nums)
        {
            if(nums.Length == 1)
            {
                return 0;
            }

            int minOpertions = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] > 0)
                {
                    if (nums[i+1] > 0)
                    {
                        nums[i+1] *= -1;
                        minOpertions++;
                    }
                }
                else
                {
                    if (nums[i + 1] < 0)
                    {
                        nums[i + 1] *= -1;
                        minOpertions++;
                    }
                }
            }

            return minOpertions;
        }

        private static int GetMin_AlternatingOperationsCountAlgorithm2(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            nums[0] *= -1;

            int minOpertions = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > 0)
                {
                    if (nums[i + 1] > 0)
                    {
                        nums[i + 1] *= -1;
                        minOpertions++;
                    }
                }
                else
                {
                    if (nums[i + 1] < 0)
                    {
                        nums[i + 1] *= -1;
                        minOpertions++;
                    }
                }
            }

            return minOpertions+1;
        }
    }
}