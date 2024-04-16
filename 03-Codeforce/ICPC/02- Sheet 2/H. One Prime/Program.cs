using System.ComponentModel.Design;

namespace H._One_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(int.TryParse(Console.ReadLine(),out int x))
            {
                bool isPrime = true;
                for(int i = 2; i < x; i++)
                {
                    if(x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }

        }
    }
}
