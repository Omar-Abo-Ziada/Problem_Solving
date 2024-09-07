namespace H._Good_or_Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] results = new string[N];

            for (int j = 0; j < N; j++)
            {
                string S = Console.ReadLine();

                bool found010 = false;
                bool found101 = false;

                for (int i = 0; i < S.Length - 2; i++)
                {
                    if (S[i] == '0' && S[i + 1] == '1' && S[i + 2] == '0')
                    {
                        found010 = true;
                    }

                    if (S[i] == '1' && S[i + 1] == '0' && S[i + 2] == '1')
                    {
                        found101 = true;
                    }

                    if (found010 || found101)
                    {
                        break;
                    }
                }

                if (found010 || found101)
                {
                    results[j] = "Good";
                }
                else
                {
                    results[j] = "Bad";
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}