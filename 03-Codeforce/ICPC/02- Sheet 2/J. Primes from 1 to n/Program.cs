using System.ComponentModel;

namespace J._Primes_from_1_to_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                for (int i = 2; i <= number ; i++)
                {
                    bool isPrime = true;

                    for(int j = 2; j <= i ; j++)
                    {
                        if (i % j == 0 && i != j)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    
                    if (isPrime)
                        Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
