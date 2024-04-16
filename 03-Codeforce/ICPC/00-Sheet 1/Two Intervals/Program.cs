namespace Two_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int l1 = int.Parse(inputs[0]);
            int r1 = int.Parse(inputs[1]);

            int l2 = int.Parse(inputs[2]);
            int r2 = int.Parse(inputs[3]);

            if (l2 >= l1 && l2 <= r1)
            {
                if (r2 >= l1 && r2 <= r1)
                {
                    Console.WriteLine($"{l2} {r2}");
                }
                else
                {
                    Console.WriteLine($"{l2} {r1}");
                }
            }
            else
            {
                Console.WriteLine("-1");
            }

        }
    }
}
