namespace F._Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] results = new string[N];

            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();

                if(S.Length < 10)
                {
                    results[i] = S;
                }
                else
                {
                    results[i] = $"{S[0]}{S.Length - 2}{S[S.Length - 1]}";
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}