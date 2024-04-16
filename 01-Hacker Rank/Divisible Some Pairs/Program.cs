namespace Divisible_Some_Pairs
{
    internal class Program
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int Valid_Pairs = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (ar[i] + ar[j] == k)
                    {
                        Valid_Pairs++;
                    }
                    else if ((ar[i] + ar[j]) % k == 0)
                    {
                        Valid_Pairs++;
                    }
                }
            }
            return Valid_Pairs;
        }

    static void Main(string[] args)
        {

        }
    }
}
