namespace Capital_or_Small_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] inputs = Console.ReadLine().Split();

            //char X = inputs[0][0];

            //int ascii_X = (int)X; 

            //Console.WriteLine(ascii_X);

            //if((int)X == 48 )


            string input = Console.ReadLine();

            char X = char.Parse(input);

            int asciiValue = (int)X;

            //Console.WriteLine(asciiValue);

            if( asciiValue >= 48 && asciiValue <= 57)
            {
                Console.WriteLine("IS DIGIT");
            }
            else if (asciiValue >= 97 && asciiValue <= 122)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS SMALL");
            }
            else if (asciiValue >= 65 && asciiValue <= 90)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS CAPITAL");
            }




        }
    }
}
