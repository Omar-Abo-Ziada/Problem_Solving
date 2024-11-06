namespace Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [4, 0, 0, 0, 0, 0];
            int m = 1;

            int[] nums2 = [1, 2, 3, 5, 6];
            int n = 5;

            /*
             Output:
            [1,2,3,5,6,4]

            Expected:
            [1,2,3,4,5,6]
             */

            Merge(nums1, m, nums2, n);

            for (int i = 0; i < m + n; i++)
            {
                Console.Write($"{nums1[i]} ");
            }
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];  
                }
                return;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (nums2[i] >= nums1[j])
                    {
                        InsertNumberInArray(nums2[i], j + 1, nums1);
                        m++;
                        break;
                    }

                    if (j == 0)
                    {
                        InsertNumberInArray(nums2[i], 0, nums1);
                        m++;
                    }
                }
            }
        }

        public static void InsertNumberInArray(int number, int index, int[] nums)
        {
            for (int i = nums.Length - 2; i >= index; i--)
            {
                nums[i + 1] = nums[i];
            }
            nums[index] = number;
        }

    }
}