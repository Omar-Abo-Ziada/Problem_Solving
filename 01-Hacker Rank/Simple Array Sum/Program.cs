namespace Simple_Array_Sum
{
    internal class Program
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum_arr = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum_arr += ar[i];
            }
            return sum_arr;
        }

        static void Main(string[] args)
        {
        }
    }
}
