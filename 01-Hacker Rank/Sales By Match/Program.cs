namespace Sales_By_Match
{
    internal class Program
    {

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[j] == 0) // accuring that the paired socks do not enter again
                    {
                        continue;
                    }
                    if (ar[i] == ar[j])  // checking the paired socks
                    {
                        pairs++;
                        ar[j] = 0;  //Marking the paired socks
                        break;
                    }
                }
            }
            return pairs;
        }
        static void Main(string[] args)
        {

        }
    }
}
