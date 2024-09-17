using System.Runtime.InteropServices;
using System.Text;

namespace Q._Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            char[] chars = S.ToCharArray();

            List<string> list = new List<string>();

            bool fullWord = false;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < chars.Length; i++)
            {

                if (((int)chars[i] >= 65 && (int)chars[i] <= 90) ||
                   ((int)chars[i] >= 97 && (int)chars[i] <= 122))
                {
                    fullWord = true;
                    stringBuilder.Append(chars[i]);
                }
                else
                {
                    if (fullWord)
                    {
                        fullWord = false;

                        string word = new string(stringBuilder.ToString());

                        list.Add(word);

                        if (i != chars.Length - 1)
                        {
                            stringBuilder.Clear();
                        }
                    }
                }
            }

            if (((int)chars[chars.Length - 1] >= 65 && (int)chars[chars.Length - 1] <= 90) ||
                  ((int)chars[chars.Length - 1] >= 97 && (int)chars[chars.Length - 1] <= 122))
            {
                string word = new string(stringBuilder.ToString());

                list.Add(word);

                stringBuilder.Clear();

            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = ReverseString(list[i]);

                if (i != list.Count-1)
                {
                    Console.Write($"{list[i]} ");

                }
                else
                {
                    Console.Write($"{list[i]}");
                }
            }


        }
        private static string ReverseString(string S)
        {
            char[] chars = S.ToCharArray();

            for (int i = 0; i < chars.Length / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = temp;
            }

            return new string(chars);
        }
    }
}
