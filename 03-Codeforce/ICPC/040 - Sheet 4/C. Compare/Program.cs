namespace C._Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();

            int minLenght = Math.Min(X.Length, Y.Length);

            int i = 0;

            while (X[i] < Y[i])
            {
                i++;
            }
        }
    }
}