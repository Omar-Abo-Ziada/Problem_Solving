namespace Remove_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            // Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]

            int k = RemoveDuplicates(nums);

            Console.WriteLine(k);

            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i]);
            }
        }

        static public int RemoveDuplicates(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;

            int k = nums.Length;
            int prevItem = nums[0];

            for (int i = 1; i < k; i++)
            {
                if (nums[i] == prevItem)
                {
                    RemoveAtIndex(nums, i);
                    k--;
                    i--;
                }
                else
                {
                    prevItem = nums[i];
                }
            }
            return k;
        }

        static void RemoveAtIndex(int[] nums, int index)
        {
            for (int i = index + 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }

            nums[nums.Length - 1] = -1;
        }
    }
}