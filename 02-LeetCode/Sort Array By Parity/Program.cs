namespace Sort_Array_By_Parity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 4 };

            int[] result = SortArrayByParity(nums);

            foreach (int item in result)
            {
                Console.Write($"{item}, ");
            }
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            int[] result = new int[nums.Length];

            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[j++] = nums[i];
                }
            }

            int k = j;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    result[k++] = nums[i];
                }
            }

            return result;
        }
    }
}
