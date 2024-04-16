namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();

            int A = int.Parse(inputs[0]);
            int B = int.Parse(inputs[1]);

            if(A >= B) 
            {
                Console.WriteLine("Yes");
            }
            else if(B > A) 
            {
                Console.WriteLine("No");
            }

        }
    }
}
