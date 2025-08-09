namespace Intersection_of_Two_Arrays_II;

internal class Program
{
    static public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1 is null || nums1.Length == 0 ||
      nums2 is null || nums2.Length == 0)
            return [];

        // 1- Create Map To store Arr 1 number-count
        Dictionary<int, int> nums1Map = new();
        foreach (int num in nums1)
        {
            if (!nums1Map.ContainsKey(num))
            {
                nums1Map.Add(num, 1);
            }
            else
            {
                nums1Map[num]++;
            }
        }

        // WRONG
        // 2- iterate over the second Arr to see if any elem of them exists in nums1Map
        // List<int> result = new();
        // foreach(int num in nums2){
        //     if(nums1Map.ContainsKey(num)){
        //         result.Add(num);
        //     }
        // }

        // WRONG
        // 2- iterate over the numsMap and check existance and count in the nums2
        // List<int> result = new();
        // foreach(KeyValuePair<int,int> pair in nums1Map){
        //     if(nums2.Any(n => n == pair.Key)){
        //         int count = nums2.Count(n => n == pair.Key);
        //         if(count > 1){
        //             for(int i = 1 ; i <= count ; i++){
        //                 result.Add(pair.Key);
        //             }
        //         }else{
        //             result.Add(pair.Key);
        //         }
        //     }
        // }

        // 2- iterate over the nums2 Arr and check existance and count in the nums1Map and every time reduce the count
        List<int> result = new();
        foreach (int num in nums2)
        {
            if (nums1Map.ContainsKey(num))
            {
                result.Add(num);
                nums1Map[num]--;

                if (nums1Map[num] == 0)
                    nums1Map.Remove(num);
            }
        }


        return result.ToArray();

    }

    static void Main(string[] args)
    {
        // Example usage
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        int[] intersection = Intersect(nums1, nums2);
        
        Console.WriteLine(string.Join(", ", intersection)); // Output: 2, 2

        int[] nums3 = { 4, 9, 5 };
        int[] nums4 = { 9, 4, 9, 8, 4 };
        int[] intersection2 = Intersect(nums3, nums4);
        
        Console.WriteLine(string.Join(", ", intersection2)); // Output: 9, 4
    }
}