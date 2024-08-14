namespace W.Shape3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                PrintSympols(i , N);
            }

            for (int i = N-1; i >= 0; i--)
            {
                PrintSympols(i, N);
            }
        }

        private static void PrintSympols(int i , int N)
        {
            int NumberOfSpaces = N - i - 1;

            for (int j = 0; j < NumberOfSpaces; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k <= (i+i); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}