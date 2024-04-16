namespace Area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            r = double.Parse(Console.ReadLine());
            double pi = 3.141592653;
            double Area = r * r * pi;
            //Console.WriteLine(String.Format("{0:0.000000000}", Area));  // one solution
            Console.WriteLine($"{Area:F9}"); // another solution

        }
    }
}
