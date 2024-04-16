namespace Digits_summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            long x = long.Parse(inputs[0]);
            long y = long.Parse(inputs[1]);

            Console.WriteLine( (x%10) + (y%10) );
        }
    }
}
