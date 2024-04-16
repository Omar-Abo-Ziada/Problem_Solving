namespace Compare_the_Triplets
{
    internal class Program
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> Result = new List<int>(2) { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    Result[0] += 1;
                }
                else if (b[i] > a[i])
                {
                    Result[1] += 1;
                }
            }
            return Result;
        }
        static void Main(string[] args)
        {
        }
    }
}
