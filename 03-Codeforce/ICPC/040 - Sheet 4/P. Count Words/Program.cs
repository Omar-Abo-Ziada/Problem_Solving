namespace P._Count_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            char[] chars = S.ToCharArray();

            int count = 0;

            bool word = false;

            for (int i = 0; i < chars.Length; i++)
            {

                if (((int)chars[i] >= 65 && (int)chars[i] <= 90) ||
                    ((int)chars[i] >= 97 && (int)chars[i] <= 122))
                {
                    word = true;
                }
                else
                {
                    if (word)
                    {
                        count++;
                        word = false;
                    }
                }
            }
            if (((int)chars[chars.Length - 1] >= 65 && (int)chars[chars.Length - 1] <= 90) ||
               ((int)chars[chars.Length - 1] >= 97 && (int)chars[chars.Length - 1] <= 122))
            {
                count++;
            }

            Console.WriteLine(count);

        }
    }
}