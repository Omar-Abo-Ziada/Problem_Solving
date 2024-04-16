namespace first_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            x /= 1000;

            //Console.WriteLine(x);

            if (x % 2 == 0)
                Console.WriteLine("EVEN");

            else
                Console.WriteLine("ODD");
        }
    }
}
