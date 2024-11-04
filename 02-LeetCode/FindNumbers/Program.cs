namespace FindNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumbers([12, 345, 234531, 6, 7896]));
        }

        static int FindNumbers(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (GetDigitsCount(nums[i]) % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static int GetDigitsCount(int number)
        {
            int digitsCount = 0;

            while (number > 0)
            {
                number /= 10;
                digitsCount++;
            }

            return digitsCount;
        }
    }
}
