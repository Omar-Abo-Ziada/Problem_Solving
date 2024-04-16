namespace Short_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);
            int C = int.Parse(inputs[2]);

            int min = Math.Min(A, Math.Min(B, C));
            int max = Math.Max(A, Math.Max(B, C));
            int mid = (A + B + C) - (min + max);

            Console.WriteLine(min);
            Console.WriteLine(mid);
            Console.WriteLine(max + "\n");

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
