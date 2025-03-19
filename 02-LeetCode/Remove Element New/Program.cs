namespace Remove_Element_New;

internal class Program
{
    static void Main(string[] args)
    {
        //Input: nums = [3, 2, 2, 3], val = 3
        //Output: 2, nums = [2, 2, _, _]

        int[] nums = new int[] { 3, 2, 2, 3 };
        int k = RemoveElement(nums, 3); //  [2,2,_,_]
        for (int i = 0; i < k; i++)
        {
            Console.Write($"{nums[i]} ");
        }

        Console.WriteLine();

        int[] nums2 = [0, 1, 2, 2, 3, 0, 4, 2];
        int k2 = RemoveElement(nums2, 2); // [0,1,4,0,3,_,_,_]
        for (int i = 0; i < k2; i++)
        {
            Console.Write($"{nums2[i]} ");
        }
    }

    static public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[k] = nums[i];
            }
            else
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}