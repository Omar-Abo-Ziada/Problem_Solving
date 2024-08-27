namespace T._Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*T. Matrix
   time limit per test1 second
   memory limit per test256 megabytes
   Given a number N and a 2D array A of size N * N. Print the absolute difference between the summation of its two diagonals (primary diagonal and secondary diagonal).

   Input
   First line contains a number N (1 ≤ N ≤ 100) described above.

   Each of the next N lines will contain N numbers ( - 100 ≤ Ai ≤ 100).

   Output
   Print the absolute difference between the summation of the matrix main diagonals.

   Example
   InputCopy
   4
   1 5 12 1
   2 -4 6 7
   3 8 5 9
   3 5 23 -6
   OutputCopy
   22
   Note
   First Example :


   */

            #endregion

            int N = int.Parse(Console.ReadLine());

            int[,] nums = new int[N, N];

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split();

                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = int.Parse(row[j]);
                }
            }

            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        mainDiagonalSum += nums[i, j];
                        //Console.WriteLine($"Main : i:{i} , j:{j} => {nums[i,j]}");
                    }

                    if(i + j == (N-1))
                    {
                        secondaryDiagonalSum += nums[i, j];
                        //Console.WriteLine($"secondary : i:{i} , j:{j} => {nums[i, j]}");
                    }

                }
            }

            int difference = Math.Abs(mainDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(difference);

        }
    }
}