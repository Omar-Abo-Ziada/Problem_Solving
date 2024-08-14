namespace V.PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse( Console.ReadLine());

            for (int i = 1; i <= (N * 4); i+=4)
            {
                Console.WriteLine($"{i} {i+1} {i+2} PUM");
            }
        }
    }
}