using System.Globalization;

namespace Valid_Mountain_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = [0, 3, 2, 1];
            //int[] arr = [2, 1];
            //int[] arr = [3, 5, 5];
            //int[] arr = [3];
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            Console.WriteLine(ValidMountainArray(arr));
        }

        static bool ValidMountainArray(int[] arr)
        {
            if (arr.Length == 1) return false;

            bool increasing = true;
            bool mountainPoint = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i != 0 && arr[i + 1] <= arr[i] && !mountainPoint)
                {
                    mountainPoint = true;
                    increasing = false;
                }

                if (arr[i + 1] <= arr[i] && !mountainPoint && increasing)
                {
                    return false;
                }

                if (arr[i + 1] >= arr[i] && mountainPoint && !increasing)
                {
                    return false;
                }
            }

            if (!mountainPoint)
            {
                return false;
            }

            return true;
        }
    }
}