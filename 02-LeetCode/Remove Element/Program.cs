namespace Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Input: nums = [3,2,2,3], val = 3
                Output: 2, nums = [2,2,_,_]
                Explanation: Your function should return k = 2, with the first two elements of nums being 2.
                It does not matter what you leave beyond the returned k (hence they are underscores).
              */

            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;

            // Output: 5, nums = [0,1,4,0,3,_,_,_]

            int k = RemoveElement(nums, val);

            Console.WriteLine(k);

            for (int i = 0; i < k; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }

        static int RemoveElement(int[] nums, int val)
        {
            int k = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    RemoveAtIndex(nums , i);
                    k--;
                    i--;
                }
            }

            return k;
        }

        static void RemoveAtIndex(int[] nums , int index)
        {
            for (int i = index + 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }

            nums[nums.Length - 1] = -1;
        }
    }
}