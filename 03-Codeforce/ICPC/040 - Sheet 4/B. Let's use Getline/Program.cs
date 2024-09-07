namespace B._Let_s_use_Getline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            foreach(char c in S)
            {
                if(c == '\\')
                {
                    break;
                }
                else
                {
                    Console.Write(c);
                }
            }

        }
    }
}
