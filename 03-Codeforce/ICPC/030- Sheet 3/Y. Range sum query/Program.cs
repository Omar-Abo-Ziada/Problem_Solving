namespace Y._Range_sum_query
{
    internal struct Pair
    {
        public int Left { get; set; }
        public int Right { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int Q = input[1];

            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] prefixSum = new long[N + 1]; // 1-based indexing

            for (int i = 1; i <= N; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i - 1];
            }

            for (int i = 0; i < Q; i++)
            {
                var query = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int L = query[0];
                int R = query[1];

                long result = prefixSum[R] - prefixSum[L - 1];
            }
        }
    }
}
