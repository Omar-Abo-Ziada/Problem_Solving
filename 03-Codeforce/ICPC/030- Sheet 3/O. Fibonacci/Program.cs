namespace O._Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int result = GetFibo(N);
            Console.WriteLine(result);
        }

        private static int GetFibo(int N)
        {
            if (N == 1) return 0;
            if (N == 2) return 1;

            int prevPrev = 0;
            int prev = 1;
            int current = 0;

            for (int i = 3; i <= N; i++)
            {
                current = prev + prevPrev;
                prevPrev = prev;
                prev = current;
            }

            return current;
        }
    }
}
