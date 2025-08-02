namespace Two_Sum
{
    internal class Program
    {
        public static int[]? TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            int iteration = 0; 

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i ; j < nums.Length; j++)
                {
                    Console.WriteLine($"iteration : {iteration} \n");
                    iteration++;

                    if (i == j)
                        continue; 

                    if (nums[i] + nums[j] == target) 
                    {
                        result[0] = i;
                        result[1] = j;

                        return result;
                    }
                }
            }
            return null; 
        }
        static void Main(string[] args)
        {

            #region Problem documentaion
            //Example 1:

            //Input: nums = [2, 7, 11, 15], target = 9
            //Output: [0,1]
            //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
            //Example 2:

            //Input: nums = [3, 2, 4], target = 6
            //Output: [1,2]
            //Example 3:

            //Input: nums = [3, 3], target = 6
            //Output: [0,1]


            //Constraints:

            //  2 <= nums.length <= 104
            //  - 109 <= nums[i] <= 109
            //  - 109 <= target <= 109
            //Only one valid answer exists.

            //Follow - up: Can you come up with an algorithm that is less than O(n2) time complexity? 
            #endregion

            int[] nums1 = [2, 7, 11, 15];
            int target1 = 9; 
            int[]? result1 = new int[2];

            result1 = TwoSum(nums1, target1);

            Console.WriteLine(result1[0]);
            Console.WriteLine(result1[1]);

            int[] nums2 = [3,2,4] ;
            int target2 = 6 ;
            int[]? result2 = new int[2] ;

            result2 = TwoSum(nums2, target2);

            Console.WriteLine(result2[0]);
            Console.WriteLine(result2[1]);

            int[] nums3 = [3, 3];
            int target3 = 6;
            int[]? result3 = new int[2];

            result3 = TwoSum(nums3, target3);

            Console.WriteLine(result3[0]);
            Console.WriteLine(result3[1]);


        }
    }
}
