using System;
using System.Text;

namespace R._String_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            StringBuilder sb = new StringBuilder(S);
            int score = 0;
            int i = 0;

            while (i < sb.Length)
            {
                char currentChar = sb[i];

                if (currentChar == 'V')
                {
                    score += 5;
                }
                else if (currentChar == 'W')
                {
                    score += 2;
                }
                else if (currentChar == 'X')
                {
                    if (i + 1 < sb.Length)
                    {
                        sb.Remove(i + 1, 1);
                    }
                }
                else if (currentChar == 'Y')
                {
                    if (i + 1 < sb.Length)
                    {
                        char nextChar = sb[i + 1];
                        sb.Remove(i + 1, 1);
                        sb.Append(nextChar);
                    }
                }
                else if (currentChar == 'Z')
                {
                    if (i + 1 < sb.Length)
                    {
                        char nextChar = sb[i + 1];
                        if (nextChar == 'V')
                        {
                            score /= 5;
                        }
                        else if (nextChar == 'W')
                        {
                            score /= 2;
                        }
                        sb.Remove(i + 1, 1);
                    }
                }
                i++;
            }

            Console.WriteLine(score);
        }
    }
}
