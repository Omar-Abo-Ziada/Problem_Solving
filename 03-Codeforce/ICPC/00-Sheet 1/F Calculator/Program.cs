namespace F_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int c = Console.Read();
            //Console.WriteLine(c);

            //char d = '3';

            //Console.WriteLine((int)d);

            string[] inputs = Console.ReadLine().Split();

            int A = int.Parse(inputs[0]);
            char o = inputs[1][0];
            int B = int.Parse(inputs[2]);

            //Console.WriteLine($"A : {A}\t B : {B}\t operator : {o}");

            if (o == '+')
            {
                Console.WriteLine(A + B);
            }
            else if (o == '-')
            {
                Console.WriteLine(A - B);
            }
            else if (o == '*')
            {
                Console.WriteLine(A * B);
            }
            else if (o == '/')
            {
                Console.WriteLine(A / B);
            }
        }
    }
}
