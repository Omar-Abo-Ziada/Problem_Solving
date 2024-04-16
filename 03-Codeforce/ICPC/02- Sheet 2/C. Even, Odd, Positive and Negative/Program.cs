namespace C._Even__Odd__Positive_and_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int even = 0;
            int odd = 0;
            int positive = 0;
            int negative = 0;

            int x;
            
            for (int i = 0; i < count; i++)
            {
                x = int.Parse(inputs[i]);

                if (x > 0)
                    positive++;
                else if(x < 0)
                    negative++;

                if(x % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {odd}");
            Console.WriteLine($"Positive: {positive}");
            Console.WriteLine($"Negative: {negative}");
        }
    }
}
