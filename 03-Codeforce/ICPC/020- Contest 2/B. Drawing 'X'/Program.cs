using System;

namespace B.Drawing_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRows; i++)
            {
                DrawLine(i, numberOfRows);
            }
        }

        private static void DrawLine(int i, int numberOfRows)
        {
            // Determine middle row
            int middleRow = (numberOfRows + 1) / 2;

            // Handle first row
            if (i == 1)
            {
                Console.WriteLine("\\" + new string('*', numberOfRows - 2) + "/");
            }
            // Handle rows above the middle
            else if (i < middleRow)
            {
                Console.WriteLine(new string('*', i - 1) + "\\" + new string('*', numberOfRows - 2 * i) + "/" + new string('*', i - 1));
            }
            // Handle the middle row
            else if (i == middleRow)
            {
                Console.WriteLine(new string('*', i - 1) + "X" + new string('*', i - 1));
            }
            // Handle rows below the middle
            else if (i > middleRow && i < numberOfRows)
            {
                int j = numberOfRows - i + 1;
                Console.WriteLine(new string('*', j - 1) + "/" + new string('*', numberOfRows - 2 * j) + "\\" + new string('*', j - 1));
            }
            // Handle last row
            else if (i == numberOfRows)
            {
                Console.WriteLine("/" + new string('*', numberOfRows - 2) + "\\");
            }
        }
    }
}
