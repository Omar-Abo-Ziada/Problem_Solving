namespace Minimum_Size_Subarray_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinSubArrayLen(7, [2, 3, 1, 2, 4, 3])); // 2
            Console.WriteLine(MinSubArrayLen(4, [1, 4, 4])); // 1
            Console.WriteLine(MinSubArrayLen(11, [1, 1, 1, 1, 1, 1, 1, 1])); // 0
        }

        // Second trying to find O(n) solution to avoid time limit exceed => using sliding window technique(2 pointers)
        static public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums is null || nums.Length == 0)
                return 0;

            int left = 0;
            int sum = 0;
            int minLength = int.MaxValue;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    int currentLength = right - left + 1;
                    minLength = Math.Min(minLength, currentLength);
                    sum -= nums[left];
                    left++;
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;
        }

        // first the brute force solution (nested loop => time O(n2)) => Works but time limit exceeded in some cases
        //static public int MinSubArrayLen(int target, int[] nums)
        //{
        //    int minimemLength = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int sum = nums[i];
        //        for (int j = i + 1; j <= nums.Length; j++)
        //        {
        //            if (sum >= target)
        //            {
        //                int currentLength = j - i;
        //                if (minimemLength == 0 || currentLength < minimemLength)
        //                {
        //                    minimemLength = currentLength;
        //                }
        //                break;
        //            }
        //            if (j < nums.Length)
        //            {
        //                sum += nums[j];
        //            }
        //        }
        //    }
        //    return minimemLength;
        //}
    }
}