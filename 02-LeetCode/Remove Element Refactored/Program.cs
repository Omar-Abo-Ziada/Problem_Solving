namespace Remove_Element_Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 2, 0,2 };

            int k = RemoveElement(nums, 2);

            for (int i = 0; i < k; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums is null || nums.Length == 0) return 0;

            int write = nums.Length - 1;
            int valOccurance = 0;

            for (int read = nums.Length - 1; read >= 0; read--)
            {
                if (nums[read] == val)
                {
                    int temp = nums[read];
                    nums[read] = nums[write];
                    nums[write] = temp;

                    write--;

                    valOccurance++;
                }
            }

            int k = nums.Length - valOccurance;
            return k;
        }
    }
}
