namespace Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-7, -3, 2, 3, 11];

            int[] result = SortedSquares(nums);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        static int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums[i];
            }

            int[] sortedArr = BubbleSort(nums);

            return sortedArr;
        }

        static int[] BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }

    }
}