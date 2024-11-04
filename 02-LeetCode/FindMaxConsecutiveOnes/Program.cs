namespace FindMaxConsecutiveOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1, 0, 1 }));
        }

        static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int currentCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 0;
                }
            }

            return Math.Max(maxCount, currentCount);
        }
    }
}
