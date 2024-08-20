namespace E._Lowest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int lowestNum = int.MaxValue;
            int lowestNumIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(inputs[i]);

                if (num < lowestNum)
                {
                    lowestNum = num;
                    lowestNumIndex = i;
                }
            }

            Console.WriteLine($"{lowestNum} {lowestNumIndex+1}");
        }
    }
}