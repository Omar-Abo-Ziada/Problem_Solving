namespace N._Max_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            // Edge case: if the length of the string is 1
            if (N == 1)
            {
                Console.WriteLine(1);
                return;
            }

            int maxLength = 1; // At least the first character is always counted
            char previousChar = S[0];

            for (int i = 1; i < N; i++)
            {
                if (S[i] != previousChar)
                {
                    maxLength++;
                    previousChar = S[i];
                }
            }

            Console.WriteLine(maxLength);
        }

    }
}