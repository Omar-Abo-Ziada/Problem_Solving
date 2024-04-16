namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char X = char.Parse(input);

            int asciiValue = (int)X;

            if (asciiValue >= 97 && asciiValue <= 122)
            {
                Console.WriteLine(input.ToUpper());
            }
            else if (asciiValue >= 65 && asciiValue <= 90)
            {
                Console.WriteLine(input.ToLower());
            }
        }
    }
}
