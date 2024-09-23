namespace V._Replace_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? S = Console.ReadLine();

            int index = S.IndexOf("EGYPT");

            while (index != -1)
            {
                string left = S.Substring(0, index);
                string right = S.Substring(index + 5);

                //Console.WriteLine(left);
                //Console.WriteLine(right);

                S = new string($"{left} {right}");

                index = S.IndexOf("EGYPT");
            }

            Console.WriteLine(S);

        }
    }
}