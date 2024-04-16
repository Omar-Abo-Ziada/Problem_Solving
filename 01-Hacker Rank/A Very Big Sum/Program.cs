namespace A_Very_Big_Sum
{
    internal class Program
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long Big_Sum = 0;
            foreach (long v in ar)
            {
                Big_Sum += v;
            }
            return Big_Sum;

        }
        static void Main(string[] args)
        {
        }
    }
}
