namespace D._Fixed_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rightPswrd = 1999;
            int enteredPserd = 0;

            while (enteredPserd != rightPswrd)
            {
                enteredPserd = int.Parse(Console.ReadLine());

                if(enteredPserd != rightPswrd)
                    Console.WriteLine("Wrong");
                else
                    Console.WriteLine("Correct");
            }
        }
    }
}
