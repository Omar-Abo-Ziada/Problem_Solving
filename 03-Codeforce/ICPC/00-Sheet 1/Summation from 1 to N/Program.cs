namespace Summation_from_1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            Console.WriteLine((x*(x+1))/2);  // big O(1) better than loops bigO(n)
        }
    }
}
