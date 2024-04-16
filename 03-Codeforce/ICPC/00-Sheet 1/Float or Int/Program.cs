namespace Float_or_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal N = decimal.Parse(Console.ReadLine());

            int right = (int)N;

            if (right == N) // or i can say ( N - right == 0 )
            {
                Console.WriteLine($"int {right}");
            }
            else
            {
                Console.WriteLine($"float {right} {N - right}");
            }

        }
    }
}
