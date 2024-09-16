    using System.Text;

    namespace K._I_Love_strings
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int N = int.Parse(Console.ReadLine());

                string[] results = new string[N];

                for (int i = 0; i < N; i++)
                {
                    string[] inputs = Console.ReadLine().Split();

                    string S = inputs[0];
                    string T = inputs[1];

                    int minLength = Math.Min(S.Length, T.Length);

                    StringBuilder sb = new StringBuilder();

                    for (int j = 0; j < minLength; j++)
                    {
                        sb.Append($"{S[j]}{T[j]}");
                        //Console.Write($"{S[j]}{T[j]}");
                    }

                    if (S.Length > T.Length)
                    {
                        for (int j = minLength; j < S.Length; j++)
                        {
                            sb.Append($"{S[j]}");
                            //Console.Write($"{S[j]}");
                        }
                    }
                    else
                    {
                        for (int j = minLength; j < T.Length; j++)
                        {
                            sb.Append($"{T[j]}");
                            //Console.Write($"{T[j]}");
                        }
                    }

                    results[i] = sb.ToString().Trim();
                    sb.Clear();
                }

                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }