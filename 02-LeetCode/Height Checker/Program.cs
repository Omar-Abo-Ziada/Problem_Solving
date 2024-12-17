using System.Globalization;

namespace Height_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = [1, 1, 4, 2, 1, 3];

            Console.WriteLine(HeightChecker(heights));
        }

        public static int HeightChecker(int[] heights)
        {
            if (heights is null || heights.Length == 0) return 0;

            int[] originalArr = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                originalArr[i] = heights[i];
            }

            bool swaped;
            for (int i = 0; i < heights.Length - 1; i++)
            {
                swaped = false;

                for (int j = 0; j < heights.Length - i - 1; j++)
                {
                    if (heights[j] > heights[j + 1])
                    {
                        int temp = heights[j];
                        heights[j] = heights[j+1];
                        heights[j+1] = temp;
                        swaped = true;
                    }
                }

                if (!swaped) break;
            }

            int wrongPlcaesCount = 0;
            for(int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != originalArr[i])
                {
                    wrongPlcaesCount++;
                }
            }

            return wrongPlcaesCount;

        }
    }
}