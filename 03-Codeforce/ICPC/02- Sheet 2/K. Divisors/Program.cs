using System.ComponentModel.Design;

namespace K._Divisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                for(int i = 1; i <= input; i++)
                {
                    if(input % i == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
