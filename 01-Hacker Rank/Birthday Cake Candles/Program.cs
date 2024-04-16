namespace Birthday_Cake_Candles
{
    internal class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            int Max_Rebeated = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[candles.Count - 1] == candles[i])
                {
                    Max_Rebeated++;
                }
            }
            Console.WriteLine(Max_Rebeated);
            return Max_Rebeated;

        }

        static void Main(string[] args)
        {

        }
    }
}
