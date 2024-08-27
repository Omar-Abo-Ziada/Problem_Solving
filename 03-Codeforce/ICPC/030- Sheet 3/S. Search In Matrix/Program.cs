namespace S._Search_In_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*S. Search In Matrix
time limit per test2 seconds
memory limit per test64 megabytes
Given two numbers N and M, a 2D array of size N * M and a number X. Determine whether X exists in the 2D array A or not.

Input
First line contains two numbers N, M (2 ≤ N, M ≤ 100) N donates number of rows and M donates number of columns.

Each of the next N lines will contain M numbers (1 ≤ Ai ≤ 105).

Last line contains a number X (0 ≤ X ≤ 105) described above.

Output
Print "will take number" if the number doesn't exist in the 2D array otherwise, print "will not take number".

Examples
InputCopy
2 2
1 2
3 4
3
OutputCopy
will not take number
InputCopy
2 2
1 2
3 4
10
OutputCopy
will take number
*/
            #endregion

            string[] inputs = Console.ReadLine().Split();

            int N = int.Parse(inputs[0]);

            int M = int.Parse(inputs[1]);

            int[,] nums = new int[N, M];

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split();

                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = int.Parse(row[j]);
                    //Console.Write($"{nums[i,j]} ");
                }
                //Console.WriteLine();
            }

            int X = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (X == nums[i, j])
                    {
                        isFound = true;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine("will not take number");
            }
            else
            {
                Console.WriteLine("will take number");
            }

            //int[,] numbers = new int[,] { { 1, 4, 2 }, { 3, 6, 8 } };

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers[i, j]);
            //    }
            //}

        }
    }
}