using System;

namespace Spiral_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] mat0 =
            [
                [1, 2, 3 , 4],
                [5, 6 , 7, 8],
                [9, 10, 11, 12],
                [13, 14, 15, 16],
            ];

            int[] result0 = SpiralOrder(mat0).ToArray();

            foreach (var item in result0)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[][] mat1 =
            [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9],
            ];

            int[] result1 = SpiralOrder(mat1).ToArray();

            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[][] mat2 =
            [
               [2,3]
            ];

            int[] result2 = SpiralOrder(mat2).ToArray();

            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[][] mat3 =
            [
               [3],
               [2]
            ];

            int[] result3 = SpiralOrder(mat3).ToArray();

            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[][] mat4 =
            [
              [1,2,3,4],
              [5,6,7,8],
              [9,10,11,12]
            ];

            int[] result4 = SpiralOrder(mat4).ToArray();

            foreach (var item in result4)
            {
                Console.Write(item + " ");
            }
        }
        static public IList<int> SpiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return Array.Empty<int>();

            int currentLeft = 0, currentRight = matrix[0].Length - 1;
            int currentTop = 0, currentBottom = matrix.Length - 1;

            List<int> result = new List<int>();

            while (currentLeft <= currentRight && currentTop <= currentBottom)
            {
                for (int i = currentLeft; i <= currentRight; i++)
                {
                    result.Add(matrix[currentTop][i]);
                }
                currentTop++;

                for (int i = currentTop; i <= currentBottom; i++)
                {
                    result.Add(matrix[i][currentRight]);
                }
                currentRight--;

                // Check if there are still rows to traverse
                if (currentTop <= currentBottom)
                {
                    for (int i = currentRight; i >= currentLeft; i--)
                    {
                        result.Add(matrix[currentBottom][i]);
                    }
                    currentBottom--;
                }

                // Check if there are still columns to traverse
                if (currentLeft <= currentRight)
                {
                    for (int i = currentBottom; i >= currentTop; i--)
                    {
                        result.Add(matrix[i][currentLeft]);
                    }
                    currentLeft++;
                }
            }

            return result;
        }
    }
}