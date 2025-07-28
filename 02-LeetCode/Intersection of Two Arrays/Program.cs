namespace Intersection_of_Two_Arrays;

internal class Program
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        if ((nums1 is null || nums1.Length == 0)
             && (nums2 is null || nums2.Length == 0))
            return [];

        HashSet<int> set1 = new (nums1);
        HashSet<int> set2 = new(nums2);

        List<int> result = new();

        foreach(int num in set2)
        {
            if (set1.Contains(num))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        Intersection(nums1, nums2);
    }
}