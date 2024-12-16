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

        }
    }
}
