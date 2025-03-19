namespace Max_Consecutive_Ones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1])); // 3
            Console.WriteLine(FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1])); // 2
        }

        static public int FindMaxConsecutiveOnes(int[] nums)
        {
            int start = 0;
            int end = 0;
            int max = 0;

            while (end < nums.Length)
            {
                if (nums[end] == 1)
                {
                    end++;
                }
                else
                {
                    max = Math.Max(max, end - start);
                    start = end + 1;
                    end++;
                }
            }

            return Math.Max(max, end - start);
        }
    }
}