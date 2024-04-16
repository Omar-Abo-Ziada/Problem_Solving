namespace Coordinates_of_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            float X = float.Parse(inputs[0]);
            float Y = float.Parse(inputs[1]);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
