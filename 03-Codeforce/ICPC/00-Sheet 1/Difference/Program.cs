namespace Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, C;
            long B, D;

            string[] inputs = Console.ReadLine().Split();

            A = int.Parse(inputs[0]);
            B = long.Parse(inputs[1]);
            C = int.Parse(inputs[2]);
            D = long.Parse(inputs[3]);

            long x = (A * B) - (C * D);

            Console.Write($"Difference= {x}");

        }
    }
}
