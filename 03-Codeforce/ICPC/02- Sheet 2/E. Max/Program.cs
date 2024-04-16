namespace E._Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int max = int.MinValue;
            for (int i = 0; i < count ; i++)
            {
                int x = int.Parse(inputs[i]);

                if(x > max)
                    max = x;
            }
            Console.WriteLine(max);
        }
    }
}
