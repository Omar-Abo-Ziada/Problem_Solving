namespace Bill_Division
{
    internal class Program
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int totalSum = bill.Sum();
            int AnnaSum = (totalSum - bill[k]) / 2;
            if (b == AnnaSum)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - AnnaSum);
            }
        }
    static void Main(string[] args)
        {

        }
    }
}
