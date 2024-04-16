namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            int i;
            long l;
            char c;
            float f;
            double d;

            string[] input = Console.ReadLine().Split();
            i = int.Parse(input[0]);
            l = long.Parse(input[1]);
            c = char.Parse(input[2]);
            f = float.Parse(input[3]);
            d = double.Parse(input[4]);

            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.WriteLine($"{f:F2}"); // Format float with 2 decimal places
            Console.WriteLine($"{d:F2}"); // Format double with 2 decimal places
        }
    }
}
