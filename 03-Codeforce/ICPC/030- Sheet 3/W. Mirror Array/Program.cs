namespace W._Mirror_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*W. Mirror Array
      time limit per test1 second
      memory limit per test256 megabytes
      Given two numbers N
      , M
       and a 2D array of size N
       * M
      . Print the inverted array that appeared in the mirror.

      Input
      First line contains two numbers N
      , M
       (1≤N,M≤100)
       N
       donates number of rows and M
       donates number of columns.

      Each of the next N
       lines will contain M
       numbers (1≤Ai,j≤109)
      .

      Output
      Print the inverted array.

      Example
      InputCopy
      3 3
      2 3 5
      7 9 20
      35 1 12
      OutputCopy
      5 3 2 
      20 9 7 
      12 1 35 
      Note

      */
            #endregion

            string[] sizes = Console.ReadLine().Split();

            int N = int.Parse(sizes[0]);
            int M = int.Parse(sizes[1]);

            int[,] nums = new int[N,M];

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split();

                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = int.Parse(row[j]);
                }
            }

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1)/2; j++)
                {
                    Swap( ref nums[i, j], ref nums[i,nums.GetLength(1)-1-j] );
                } 
            }

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i,j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void Swap(ref int  A , ref int B)
        {
            int temp = A;
            A = B; 
            B = temp;
        }
    }
}