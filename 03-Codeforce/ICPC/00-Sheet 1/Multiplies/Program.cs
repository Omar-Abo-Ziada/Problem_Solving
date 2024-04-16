namespace Multiplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            long A = long.Parse(inputs[0]);
            long B = long.Parse(inputs[1]);

            if( A % B == 0 || B % A == 0) 
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("No Multiples");
            }
        }
    }
}
