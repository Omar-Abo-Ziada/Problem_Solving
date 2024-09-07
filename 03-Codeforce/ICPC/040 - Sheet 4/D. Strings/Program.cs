namespace D._Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            Console.WriteLine($"{A.Length} {B.Length}");
            Console.WriteLine($"{A}{B}");

            char[] charA = A.ToCharArray();
            char[] charB = B.ToCharArray();

            char temp = charA[0];
            charA[0] = charB[0];
            charB[0] = temp;

            Console.WriteLine($"{new string(charA)} {new string(charB)}");
        }
    }
}