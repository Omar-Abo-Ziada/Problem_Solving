namespace K._I_Love_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] resulst = new string[N];

            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                string T = Console.ReadLine();

                char[] S_Arr = S.ToCharArray();
                char[] T_Arr = T.ToCharArray();

                int minLength = Math.Min(S.Length , T.Length);

                List<char> result = new List<char>();

                for (int j = 0; j < minLength; j++)
                {
                    //resulst.Append();
                }
            }
        }
    }
}