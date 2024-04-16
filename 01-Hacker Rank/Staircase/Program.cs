namespace Staircase
{
    internal class Program
    {
        public static void staircase(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n - i - 1; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    string hash = "";
                    hash += "#";
                    Console.Write(hash);
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
        }
    }
}
