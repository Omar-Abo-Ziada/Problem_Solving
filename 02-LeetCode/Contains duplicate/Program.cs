using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;

namespace Contains_duplicate
{
    internal class Program
    {
        static public bool ContainsDuplicate(int[] nums)
        {
           for(int i = 0; i < nums.Length-1; i++)
            {    
                for (int j = i ; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                            return true;             
                }
            }
           return false ;
        }
        static void Main(string[] args)
        {
            #region problem documentaion
            //Given an integer array nums, return true if any value appears at least twice in the array,
            //    and return false if every element is distinct.

            //Example 1:

            //Input: nums = [1, 2, 3, 1]
            //Output: true
            //Example 2:

            //Input: nums = [1, 2, 3, 4]
            //Output: false
            //Example 3:

            //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
            //Output: true



            //Constraints:

            //1 <= nums.length <= 105
            //- 109 <= nums[i] <= 109    
            #endregion

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(nums1));
            sw.Stop();

            Console.WriteLine($"time : {sw}");


            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate(nums2));


            int[] nums3 = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
            Console.WriteLine(ContainsDuplicate(nums3));

        }
    }
}
