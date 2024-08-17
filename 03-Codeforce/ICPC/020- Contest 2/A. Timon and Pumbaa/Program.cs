namespace A._Timon_and_Pumbaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            if(A - B >= 0)
            {
                Console.WriteLine(A - B);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}