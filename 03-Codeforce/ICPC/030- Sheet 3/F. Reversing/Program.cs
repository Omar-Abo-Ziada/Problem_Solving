namespace F._Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int[] reversedNums = new int[n];

            int j = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                reversedNums[j++] = nums[i];
                Console.Write($"{reversedNums[--j]} ");
            }
        }
    }
}
