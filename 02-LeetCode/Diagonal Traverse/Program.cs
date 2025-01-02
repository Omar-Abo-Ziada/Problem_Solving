namespace Diagonal_Traverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 =
            [
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9],
            ];

            int[] result1 = FindDiagonalOrder(mat1);

            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[][] mat2 =
            [
               [2,3]
            ];

            int[] result2 = FindDiagonalOrder(mat2);

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

            int[] result3 = FindDiagonalOrder(mat3);

            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }
        }

        static public int[] FindDiagonalOrder(int[][] mat)
        {
            if (mat == null || mat.Length == 0 || mat[0].Length == 0)
                return Array.Empty<int>();

            bool isGoingUp = true;

            int currentRow = 0;
            int currentColumn = 0;

            List<int> result = new List<int>();

            int rowLength = mat.Length; 
            int colLength = mat[0].Length; 

            while (currentRow < rowLength && currentColumn < colLength)
            {
                if (isGoingUp)
                {
                    while (currentRow >= 0 && currentColumn < colLength)
                    {
                        if (currentColumn < mat[currentRow].Length) // Check if column is valid for the current row => Very Important because the input is jagged array
                        {
                            result.Add(mat[currentRow][currentColumn]);
                        }
                        currentRow--;
                        currentColumn++;
                    }

                    if (currentColumn >= colLength)
                    {
                        currentColumn--;
                        currentRow += 2;
                    }
                    else if (currentRow < 0)
                    {
                        currentRow++;
                    }

                    isGoingUp = false;
                }
                else
                {
                    while (currentRow < rowLength && currentColumn >= 0)
                    {
                        if (currentColumn < mat[currentRow].Length) // Check if column is valid for the current row => Very Important because the input is jagged array
                        {
                            result.Add(mat[currentRow][currentColumn]);
                        }
                        currentRow++;
                        currentColumn--;
                    }

                    if (currentRow >= rowLength)
                    {
                        currentRow--;
                        currentColumn += 2;
                    }
                    else if (currentColumn < 0)
                    {
                        currentColumn++;
                    }

                    isGoingUp = true;
                }
            }

            return result.ToArray();
        }

    }
}
