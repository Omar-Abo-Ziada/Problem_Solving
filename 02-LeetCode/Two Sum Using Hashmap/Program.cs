namespace Two_Sum_Using_Hashmap;

internal class Program
{

    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums is null || nums.Length == 0) return [];

        Dictionary<int, int> numsDictionary = new();

        for (int i = 0; i < nums.Length; i++)
        {

            // the value needed to complete the current I to target
            int remain = target - nums[i];

            // store the value needed to complete this index to target
            numsDictionary.TryAdd(remain, i);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (numsDictionary.ContainsKey(nums[i]) && numsDictionary[nums[i]] != i)
            {
                int completeIndex = numsDictionary[nums[i]];
                return [i, completeIndex];
            }
        }

        return [];
    }


    static void Main(string[] args)
    {
        //Example 1:
        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0,1]
        //TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        TwoSum(new int[] { 3,3}, 6);

        //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
        //Example 2:
        //Input: nums = [3, 2, 4], target = 6
        //Output: [1,2]
        //Example 3:
        //Input: nums = [3, 3], target = 6
        //Output: [0,1]
    }
}
