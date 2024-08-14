namespace Y._Easy_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int prevPrev = 0;
            int prev = 0;
            int current = 0;

            for (int i = 0; i < N; i++)
            {
                if(i == 1)
                {
                    prev = 1;
                }

                if(i == 2)
                {
                    prevPrev = 0;
                }

                current = prev + prevPrev ;

                Console.WriteLine(current);

                prevPrev = prev;

                prev = current;
            }
        }
    }
}