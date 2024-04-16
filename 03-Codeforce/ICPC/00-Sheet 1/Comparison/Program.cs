namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int A = int.Parse(inputs[0]);
            char o = inputs[1][0];
            int B = int.Parse(inputs[2]);

            //Console.WriteLine($"A : {A}\t B : {B}\t operator : {o}");

            if (o == '>')
            {
                if (A > B)
                    Console.WriteLine("Right");

                else
                    Console.WriteLine("Wrong");
            }
            else if (o == '<')
            {
                if (A < B)
                    Console.WriteLine("Right");

                else
                    Console.WriteLine("Wrong");
            }
            else if (o == '=')
            {
                if (A == B)
                    Console.WriteLine("Right");

                else
                    Console.WriteLine("Wrong");
            }
        }
    }
}
