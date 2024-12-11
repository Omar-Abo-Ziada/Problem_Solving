namespace Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 0, 3, 12];

            int[] newNums = MoveZeroes(nums);

            foreach (int i in newNums)
            {
                Console.Write(i);
            }
        }

        public static int[] MoveZeroes(int[] nums)
        {
            if (nums is null || nums.Length == 0) return Array.Empty<int>();

            //int nonZerosCount = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 0)
            //        nonZerosCount++;
            //}

            //if (nonZerosCount == 0) return Array.Empty<int>(); ;

            int[] newNums = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[0] == 0)
                {
                    newNums[j++] = i;
                }
            }
                        
            return newNums;
        }
    }
}