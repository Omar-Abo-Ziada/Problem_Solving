using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Product_of_Array_excpet_self
{
    internal class Program
    {
        static public int[] ProductExceptSelf(int[] nums)
        {

            int n = nums.Length;

            // Initialize two arrays to store products from left and right
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];

            // Initialize the result array
            int[] result = new int[n];

            // Calculate left products
            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                leftProducts[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // Calculate right products
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                rightProducts[i] = rightProduct;
                rightProduct *= nums[i];
            }

            // Calculate the final result
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
            //int[] result = new int[nums.Length];

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    result[i] =  1 ;

            //    for(int j = 0; j < nums.Length; j++)
            //    {
            //        if (i != j)
            //           result[i] *= nums[j] ;
            //    }
            //}
            //return result ;
        }
        static void Main(string[] args)
        {
            #region problem documentation
            //    Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

            //    The product of any prefix or suffix of nums is guaranteed to fit in a 32 - bit integer.

            //    You must write an algorithm that runs in O(n) time and without using the division operation.



            //    Example 1:

            //    Input: nums = [1, 2, 3, 4]
            //    Output: [24,12,8,6]
            //    Example 2:

            //    Input: nums = [-1, 1, 0, -3, 3]
            //    Output: [0,0,9,0,0]


            //    Constraints:

            //                2 <= nums.length <= 105
            //                - 30 <= nums[i] <= 30
            //    The product of any prefix or suffix of nums is guaranteed to fit in a 32 - bit integer.



            //    Follow up: Can you solve the problem in O(1) extra space complexity ? (The output array does not count as extra space for space complexity analysis.) 
            #endregion

            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = ProductExceptSelf(nums1);
            foreach(int i in result1)
            {
                Console.Write($"{i}\t");
            }

            int[] nums2 = [-1, 1, 0, -3, 3];
            int[] result2 = ProductExceptSelf(nums2);
            foreach (int i in result2)
            {
                Console.Write($"{i}\t");
            }



        }
    }
}
