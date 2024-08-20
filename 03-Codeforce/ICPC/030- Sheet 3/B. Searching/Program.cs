namespace B._Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
           B. Searching
time limit per test2 seconds
memory limit per test64 megabytes
Given a number N and an array A of N numbers. Determine if the number X exists in array A or not and print its position (0-index).

Note: X may be found once or more than once and may not be found.

Input
First line contains a number N (1 ≤ N ≤ 105) number of elements.

Second line contains N numbers (0 ≤ Ai ≤ 109).

Third line contains a number X (0 ≤ X ≤ 109).

Output
Print the position of X in the first time you find it. If it doesn't exist print -1.

Examples
InputCopy
3
3 0 1
0
OutputCopy
1
InputCopy
5
1 3 0 4 5
10
OutputCopy
-1
InputCopy
4
2 3 2 1
2
OutputCopy
0
*/ 
            #endregion

            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            long[] nums = new long[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = long.Parse(inputs[i]);
            }

            long x = long.Parse(Console.ReadLine());

            Console.WriteLine(IsFound(nums , x));


        }

        private static int IsFound(long[] nums , long x)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (x == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
