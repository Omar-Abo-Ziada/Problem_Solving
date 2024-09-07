namespace I._Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            bool isPalindrom = true;

            for (int i = 0; i < S.Length/2; i++)
            {
                if (S[i] != S[S.Length-1-i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}