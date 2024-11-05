using System.Reflection;

namespace Duplicate_Zeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Input: arr = [1,0,2,3,0,4,5,0]
             Output: [1,0,0,2,3,0,0,4]
            */

            int[] arr = [1, 0, 2, 3, 0, 4, 5, 0];

            DuplicateZeros(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    InsertNumberInArray(0, i, arr);
                    i++;
                }
            }
        }

        public static void InsertNumberInArray(int number, int index, int[] nums)
        {
            for (int i = nums.Length - 2; i >= index; i--)
            {
                nums[i + 1] = nums[i];
            }

            nums[index] = number;
        }

    }
}
