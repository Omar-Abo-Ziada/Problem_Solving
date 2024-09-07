namespace G._Even_Hate_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*G. Even Hate Odd
    time limit per test5 seconds
    memory limit per test256 megabytes
    You are given an array a
     of n
     integers. You have two kinds of operations

    increment any element in a
     (increase it by one).
    decrement any element in a
     (decrease it by one).
    What is the minimum number of operations to make the number of even elements equal to the number of odd elements, or detect that this is impossible?

    Input
    The first line contains a single integer t(1≤t≤10)
     the number of test cases.

    The first line of each test case contains an integer n(1≤n≤105)
     the number of elements in the array a
     .

    The second line of each test case contains n
     integers ai(1≤ai≤105)
     the elements of the array a
    .

    Output
    For each test case, print the minimum number of operations required, or −1
     if it's impossible

    Example
    InputCopy
    3
    4
    1 2 3 4
    4
    1 1 1 1
    3
    1 2 3
    OutputCopy
    0
    2
    -1
    */
            #endregion

            int N = int.Parse(Console.ReadLine());

            int[] results = new int[N];


            for (int i = 0; i < N; i++)
            {
                int lenght = int.Parse(Console.ReadLine());

                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                results[i] = GetMinOpertaions(nums);
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static int GetMinOpertaions(int[] nums)
        {
            if (nums.Length % 2 != 0)
            {
                return -1;
            }

            int evenCount = nums.Count(x => x % 2 == 0);
            int oddCount = nums.Count(x => x % 2 != 0);

            if(evenCount == oddCount)
            {
                return 0;
            }

            return Math.Abs((evenCount - oddCount)/2);
        }


        //private static int GetMimEven_OddOperations(int[] nums)
        //{
        //    if(nums.Length % 2 != 0)
        //    {
        //        return -1;
        //    }

        //    int[] nums2 = new int[nums.Length];

        //    Array.Copy(nums , nums2 , nums.Length);

        //    int minOpertaions1 = 0;

        //    for (int i = 0; i < nums.Length-1; i++)
        //    {
        //        if (nums[i] % 2 == 0)
        //        {
        //            if (nums[i+1] % 2 == 0)
        //            {
        //                nums[i + 1] += 1;
        //                minOpertaions1++;
        //            }
        //        }
        //        else
        //        {
        //            if (nums[i + 1] % 2 != 0)
        //            {
        //                nums[i + 1] += 1;
        //                minOpertaions1++;
        //            }
        //        }
        //    }

        //    nums2[0] += 1;

        //    int minOpertaions2 = 0;

        //    for (int i = 0; i < nums2.Length-1; i++)
        //    {
        //        if (nums2[i] % 2 == 0)
        //        {
        //            if (nums2[i + 1] % 2 == 0)
        //            {
        //                nums2[i + 1] += 1;
        //                minOpertaions2++;
        //            }
        //        }
        //        else
        //        {
        //            if (nums2[i + 1] % 2 != 0)
        //            {
        //                nums2[i + 1] += 1;
        //                minOpertaions2++;
        //            }
        //        }
        //    }

        //    int result = Math.Min(minOpertaions1,minOpertaions2);

        //    return  result;
        //}
    }
}