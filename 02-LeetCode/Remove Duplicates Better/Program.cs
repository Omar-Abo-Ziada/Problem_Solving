using System.Reflection;

namespace Remove_Duplicates_Better
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 1, 2, 3, 3, 4];

            //int[] newArr = RemoveDuplicatesBetterTime(nums);

            //Console.WriteLine(newArr);

            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.Write(nums[i]);
            //}

            int newArrLength = RemoveDuplicatesBetterTimeAndSpace(nums);

            Console.WriteLine(newArrLength);

            for (int i = 0; i < newArrLength; i++)
            {
                Console.Write(nums[i]);
            }
        }

        // time => O(N)  , space => O(N)
        private static int[] RemoveDuplicatesBetterTime(int[] nums)
        {
            if (nums is null || nums.Length == 0) return nums;

            int uniqueCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    uniqueCount++;
                }
            }

            int[] uniqueArr = new int[uniqueCount];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    uniqueArr[j++] = nums[i];
                }
            }

            return uniqueArr;
        }

        // time => O(N)  , space => O(1) (Two-pointers technique)
        private static int RemoveDuplicatesBetterTimeAndSpace(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;

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