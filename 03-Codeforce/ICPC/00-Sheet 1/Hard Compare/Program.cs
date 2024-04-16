namespace Hard_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);
            long C = long.Parse(inputs[2]);
            long D = long.Parse(inputs[3]);

            if ((B * Math.Log(A, 2)) < (D * Math.Log(C, 2)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
