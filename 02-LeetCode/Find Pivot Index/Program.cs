namespace Find_Pivot_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 7, 3, 6, 5, 6]; // Expected Output: 3
            int[] nums2 = [1, 2, 3]; // Expected Output: -1
            int[] nums3 = [2, 1, -1]; // Expected Output: 0
            int[] nums4 = [-1, -1, 0, 1, 1, 0]; // Expected Output: 5 .. output: -1

            Console.WriteLine(PivotIndex(nums1));
            Console.WriteLine(PivotIndex(nums2));
            Console.WriteLine(PivotIndex(nums3));
            Console.WriteLine(PivotIndex(nums4));
        }

        static public int PivotIndex(int[] nums)
        {
            if (nums is null || nums.Length == 0) return -1;

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = nums.Length - 1; i >= 1; i--)
            {
                sumRight += nums[i];
            }

            for (int i = 0; i < nums.Length ; i++)
            {
                if (sumLeft == sumRight)
                {
                    return i;
                }
                else if(sumLeft != sumRight && i < nums.Length - 1)
                {
                    sumLeft += nums[i];
                    sumRight -= nums[i + 1];
                }
            }

            return -1;
        }
    }
}
