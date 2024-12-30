namespace Largest_Number_At_Least_Twice_of_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [3, 6, 1, 0]; // expected output: 1
            int[] nums2 = [1, 2, 3, 4]; // expected output: -1
            int[] nums3 = [1, 0]; // expected output: 0 ,,, output : -1
            int[] nums4 = [0, 2, 3, 0]; // expected output: -1 ,,, output : 2

            Console.WriteLine(DominantIndex(nums1));
            Console.WriteLine(DominantIndex(nums2));
            Console.WriteLine(DominantIndex(nums3));
            Console.WriteLine(DominantIndex(nums4));

        }

        static public int DominantIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            int largestIndex = 0;
            int largestValue = nums[0];
            int secondLargestValue = int.MinValue;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > largestValue)
                {
                    secondLargestValue = largestValue;
                    largestValue = nums[i];
                    largestIndex = i;
                }
                else if (nums[i] > secondLargestValue)
                {
                    secondLargestValue = nums[i];
                }
            }

            if (largestValue >= secondLargestValue + secondLargestValue)
            {
                return largestIndex;
            }
            else
            {
                return -1;
            }
        }

    }
}