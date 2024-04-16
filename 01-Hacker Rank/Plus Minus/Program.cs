namespace Plus_Minus
{
    internal class Program
    {
        public static void plusMinus(List<int> arr)
        {
            decimal p = 0;
            decimal n = 0;
            decimal z = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                    p++;
                else if (i < 0)
                    n++;
                else z++;
            }
            Console.WriteLine($"{(p / arr.Count):0.000000}");
            Console.WriteLine($"{(n / arr.Count):0.000000}");
            Console.WriteLine($"{(z / arr.Count):0.000000}");
        }

        static void Main(string[] args)
        {
        }
    }
}
