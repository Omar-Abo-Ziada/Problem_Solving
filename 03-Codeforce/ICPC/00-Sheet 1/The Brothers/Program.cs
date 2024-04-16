namespace The_Brothers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            string F1 = first[0];
            string S1 = first[1];

            string F2 = second[0];
            string S2 = second[1];

            if( S1 == S2)
            {
                Console.WriteLine("ARE Brothers");
            }
            else
            {
                Console.WriteLine("NOT");
            }

        }
    }
}
