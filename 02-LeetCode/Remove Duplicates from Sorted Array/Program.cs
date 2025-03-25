namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 1, 2];
            int newLength = RemoveDuplicates(nums);
            for (int i = 0; i < newLength; i++)
            {
                Console.WriteLine(nums[i] + " ");
            }
            Console.WriteLine();
            int[] nums2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int newLength2 = RemoveDuplicates(nums2);
            for (int i = 0; i < newLength2; i++)
            {
                Console.WriteLine(nums2[i] + " ");
            }
        }

        // time => O(N)  , space => O(1) (Two-pointers technique)
        static public int RemoveDuplicates(int[] nums)
        {
            if (nums is null || nums.Length == 0)
                return 0;

            int writePointer = 1;
            for (int readPointer = 1; readPointer < nums.Length; readPointer++)
            {
                if (nums[readPointer] != nums[readPointer - 1])
                {
                    nums[writePointer] = nums[readPointer];
                    writePointer++;
                }
            }

            return writePointer;
        }
    }
}
