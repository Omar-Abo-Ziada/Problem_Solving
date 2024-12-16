namespace Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1];

            //int[] newNums = MoveZeroesExtraSpace(nums);

            //foreach (int i in newNums)
            //{
            //    Console.Write(i + " ");
            //}

            MoveZeroesTwoPointers(nums);

            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
        }

        public static int[] MoveZeroesExtraSpace(int[] nums)
        {
            if (nums is null || nums.Length == 0) return Array.Empty<int>();

            int nonZerosCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) nonZerosCount++;
            }

            if (nonZerosCount == 0) return Array.Empty<int>(); ;

            int[] newNums = new int[nonZerosCount];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    newNums[j++] = nums[i];
                }
            }

            return newNums;
        }

        public static void MoveZeroesTwoPointers(int[] nums)
        {
            if (nums is null || nums.Length == 0 || nums.Length == 1) return;

            int witePointer = 0;
            for (int readPointer = 0; readPointer < nums.Length; readPointer++)
            {
                if (nums[readPointer] != 0)
                {
                    nums[witePointer] = nums[readPointer];

                    if (readPointer != witePointer)
                    {
                        nums[readPointer] = 0;
                    }

                    witePointer++;
                }
            }
        }
    }
}