namespace Z_._Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int K = int.Parse(inputs[0]);
            int S = int.Parse(inputs[1]);

            int NumOfGroups = 0; 

            for (int i = 0; i <= K; i++)
            {
                for (int j = 0; j <= K; j++)
                {
                    if ( ( (S - i - j) >= 0 ) )
                    {
                        NumOfGroups++;
                    }
                }
            }

            Console.WriteLine(NumOfGroups);
        }
    }
}