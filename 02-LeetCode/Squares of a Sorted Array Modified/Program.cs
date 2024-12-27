namespace Squares_of_a_Sorted_Array_Modified
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-4, -1, 0, 3, 10]; // Output: [0,1,9,16,100]
            //int[] nums = [-7, -3, 2, 3, 11]; // Output: [4,9,9,49,121]


            int[] result = SortedSquares(nums);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        public static int[] SortedSquares(int[] nums)
        {
            if (nums is null || nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            int left = 0;
            int right = nums.Length - 1;
            int index = nums.Length - 1; // => the counter that write in the result Arr

            int[] result = new int[nums.Length];

            while (left < right)
            {
                if (Math.Abs(nums[right]) > Math.Abs(nums[left]))
                {
                    result[index] = nums[right] * nums[right];
                    index--;
                    right--;
                }
                else 
                {
                    result[index] = nums[left] * nums[left];
                    index--;
                    left++;
                }
            }

            result[index] = nums[right] * nums[right];

            return result;

        }

    }
}
