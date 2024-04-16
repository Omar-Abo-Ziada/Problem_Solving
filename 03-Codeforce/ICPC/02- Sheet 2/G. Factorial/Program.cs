using System.Diagnostics.CodeAnalysis;

namespace G._Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            
            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int[] result = new int[nums.Length];

            for (int i = 0;i < size; i++)
            {
                result[i] = 1;
                for (int j = 1; j <= nums[i]; j++)
                {
                    result[i] *= j;
                }
            }

            foreach (int i in result)
                Console.WriteLine(i);
        }
    }
}
