namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 4, 5, 6, 7];
            int k1 = 3;
            Rotate(nums1, k1); // [5, 6, 7, 1, 2, 3, 4]
            foreach (var item in nums1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[] nums2 = [-1, -100, 3, 99];
            int k2 = 2;
            Rotate(nums2, k2); // [3 , 99 ,  -1 , -100]

            foreach (var item in nums2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int[] nums3 = [1, 2, 3];
            int k3 = 1;
            Rotate(nums3, k3); // [3,1,2]

            foreach (var item in nums3)
            {
                Console.Write(item + " ");
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k == 0)
                return;

            k = k % nums.Length; 

            Reverse(nums, 0, nums.Length - 1);

            Reverse(nums, 0, k - 1);

            Reverse(nums, k, nums.Length - 1);
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        // old solution not working in all cases
        // Second solution (using in-place replacements) => time O(n) and space O(1)
        //static public void Rotate(int[] nums, int k)
        //{
        //    if (nums is null || nums.Length == 0 || k == 0 || nums.Length == 1)
        //        return;

        //    k = k % nums.Length;

        //    if (nums.Length % k == 0)
        //    {
        //        for (int i = 0; i < nums.Length / 2; i++)
        //        {
        //            int temp = nums[i];
        //            nums[i] = nums[nums.Length / 2 + i];
        //            nums[nums.Length / 2 + i] = temp;
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < nums.Length - k - 1; i++)
        //        {
        //            int temp = nums[i];
        //            nums[i] = nums[k + i + 1];
        //            nums[k + i + 1] = temp;
        //        }
        //        for (int i = k; i < nums.Length - 1; i++)
        //        {
        //            int temp = nums[i + 1];
        //            nums[i + 1] = nums[i];
        //            nums[i] = temp;
        //        }
        //    }
        //}


        // first the easiest solution (using extra array) => time O(n) and space O(n)
        //static public void Rotate(int[] nums, int k)
        //{
        //    k = k % nums.Length;

        //    int[] newNums = new int[nums.Length];

        //    int counter = k;
        //    for (int i = 0; i < nums.Length - k; i++)
        //    {
        //        newNums[counter] = nums[i];
        //        counter++;
        //    }

        //    for (int i = 0; i < k; i++)
        //    {
        //        newNums[i] = nums[nums.Length - k + i];
        //    }

        //    foreach (var item in newNums)
        //    {
        //        Console.Write(item + " ");
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[i] = newNums[i];
        //    }
        //}
    }
}