namespace O._Sort_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string S = Console.ReadLine();

            char[] chars = S.ToCharArray();

            for (int i = 0; i < chars.Length-1; i++)
            {
                bool sorted = true;

                for (int j = 1; j < chars.Length; j++)
                {
                    if (chars[j-1] > chars[j])
                    {
                        char temp = chars[j];
                        chars[j] = chars[j-1];
                        chars[j-1] = temp;

                        sorted = false;
                    }
                }

                if (sorted)
                {
                    break;
                }
            }

            foreach (var item in chars)
            {
                Console.Write(item);
            }
        }
    }
}