namespace L._Max_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short numOfTestCases = short.Parse(Console.ReadLine());

            for (int i = 0; i < numOfTestCases; i++)
            {
                short N = short.Parse(Console.ReadLine());
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                MaxSubArray(nums);
                Console.WriteLine();
            }
        }

        private static void MaxSubArray(int[] nums)
        {
            for (int start = 0; start < nums.Length; start++)
            {
                int max = nums[start];

                for (int end = start; end < nums.Length; end++)
                {
                    if (nums[end] > max)
                    {
                        max = nums[end];
                    }

                    Console.Write($"{max} ");
                }
            }
        }
    }
}
