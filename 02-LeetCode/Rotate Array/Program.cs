namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [1, 2, 3, 4, 5, 6, 7];
            int k1 = 3;
            Rotate(nums1, k1); // [5, 6, 7, 1, 2, 3, 4]

            Console.WriteLine(
                );
            int[] nums2 = [-1, -100, 3, 99];
            int k2 = 2;
            Rotate(nums2, k2); // [3 , 99 ,  -1 , -100]
        }

        // first the easiest solution (using extra array) => time O(n) and space O(n)
        static public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;

            int[] newNums = new int[nums.Length];

            int counter = k;
            for (int i = 0; i < nums.Length - k; i++)
            {
                newNums[counter] = nums[i];
                counter++;
            }

            for (int i = 0; i < k; i++)
            {
                newNums[i] = nums[nums.Length - k + i];
            }

            foreach (var item in newNums)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = newNums[i];
            }
        }
    }
}