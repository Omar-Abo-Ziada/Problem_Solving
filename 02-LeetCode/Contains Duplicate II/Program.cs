namespace Contains_Duplicate_II;

internal class Program
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums is null || nums.Length == 0) return false;

        Dictionary<int, int> hashMap = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hashMap.ContainsKey(nums[i]))
            {
                hashMap.Add(nums[i], i);
            }
            else
            {
                int j = hashMap[nums[i]];
                int absDistance = Math.Abs(i - j);
                if (absDistance <= k)
                {
                    return true;
                }

                // update to the latest index to avoid always comparing with the first one
                hashMap[nums[i]] = i;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        // Example usage
        int[] nums = { 1, 2, 3, 1 };
        int k = 3;
        bool result = ContainsNearbyDuplicate(nums, k);
        Console.WriteLine(result); // Output: True

        nums = new[] { 1, 0, 1, 1 };
        k = 1;
        result = ContainsNearbyDuplicate(nums, k);
        Console.WriteLine(result); // Output: True

        nums = new[] { 1, 2, 3, 1, 2, 3 };
        k = 2;
        result = ContainsNearbyDuplicate(nums, k);
        Console.WriteLine(result); // Output: False
    }
}