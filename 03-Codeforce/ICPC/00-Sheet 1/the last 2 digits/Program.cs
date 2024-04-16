using System.Diagnostics.Metrics;
using System.Numerics;

namespace the_last_2_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          * a very important constarin here is : 2 <= A , B , C , D <= 10^9 
          * so we can't multiply directly because they are very large int and we will git overflow by the end
          * rule : if u have the last 2 digits of numbers and multiplied the numbers or the last 2 digits 
                   u will get the last 2 digits similiar in both reuslts .

          * so we only need to take the last 2 digits of each number first
              then multiply them and we will get the same result
          */
            string[] inputs = Console.ReadLine().Split();

            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            int C = int.Parse(inputs[2]);
            int D = int.Parse(inputs[3]);

            A %= 100; B %= 100; C %= 100; D %= 100;

            long multiplyResult = A * B * C * D;
            multiplyResult %= 100;

            if( multiplyResult < 10 )  // means it's only one digit 
            {
                Console.WriteLine($"0{multiplyResult}"); //then add 0 before it like : 05 ==> to avoid the judge protocaol
            }
            else
            {
                Console.WriteLine(multiplyResult); // 2 digits then print it like : 25
            }
        }
    }
}
