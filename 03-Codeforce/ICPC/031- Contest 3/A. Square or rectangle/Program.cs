namespace A._Square_or_rectangle
{
    internal struct Shape
    {
        internal int Width { get; set; }
        internal int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*A. Square or rectangle
   time limit per test1 second
   memory limit per test256 megabytes
   Given the width and the height of a shape determine whether it's for a square or a rectangle?

   Input
   The first line contains a single integer t(1≤t≤1000)
    the number of test cases.

   The first and only line of each test case contains two integers w,h(1≤w,h≤106)
    representing the width and the height, respectively.

   Output
   For each test case print 'Square' if the shape is a square otherwise print 'Rectangle';

   Example
   InputCopy
   3
   10 10
   13 200
   300 300
   OutputCopy
   Square
   Rectangle
   Square
   */ 
            #endregion

            int N = int.Parse(Console.ReadLine());

            Shape[] shapes = new Shape[N];

            for (int i = 0; i < N; i++)
            {
                string[] shape = Console.ReadLine().Split();

                shapes[i].Width = int.Parse(shape[0]);
                shapes[i].Height = int.Parse(shape[1]);
            }

            foreach (var item in shapes)
            {
                if(item.Width == item.Height)
                {
                    Console.WriteLine("Square");
                }
                else
                {
                    Console.WriteLine("Rectangle");
                }
            }

        }
    }
}