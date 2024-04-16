namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            long y; 

           string[] input = Console.ReadLine().Split();
            x = int.Parse(input[0]);
            y = long.Parse(input[1]);

            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            Console.WriteLine($"{x} - {y} = {x-y}");

        }
    }
}
