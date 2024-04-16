namespace L._GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            if ( (int.TryParse(inputs[0], out int n1) ) && ( int.TryParse(inputs[1], out int n2) ) )
            {
                int min = Math.Min( n1, n2 );
                int max = Math.Max( n1, n2 );

                int GCD = 1;

                for (int i = 1; i <= min; i++)
                {
                    if (max % i == 0 && min % i == 0)
                        GCD = i;
                }
                Console.WriteLine(GCD);
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
