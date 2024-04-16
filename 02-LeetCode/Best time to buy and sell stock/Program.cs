using System.Diagnostics;

namespace Best_time_to_buy_and_sell_stock
{
    internal class Program
    {
        static public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice = int.MaxValue; 

           for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];

                else if ((prices[i] - minPrice ) > maxProfit)
                    maxProfit = prices[i] - minPrice;                   
            }
            return maxProfit; 
        }
        static void Main(string[] args)
        {
            #region problem documentaion
            /*
                 * You are given an array prices where prices[i] is the price of a given stock on the ith day.

                You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

                Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.


                Example 1:

                Input: prices = [7,1,5,3,6,4]
                Output: 5
                Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
                Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
                Example 2:

                Input: prices = [7,6,4,3,1]
                Output: 0
                Explanation: In this case, no transactions are done and the max profit = 0.


                Constraints:

                1 <= prices.length <= 105
                0 <= prices[i] <= 104

                 */
            #endregion

            int[] prices1 = [7, 1, 5, 3, 6, 4];

            Console.WriteLine(MaxProfit(prices1));

            int[] prices2 = [ 1 , 2 ];

            Console.WriteLine(MaxProfit(prices2));

        }
    }
}
