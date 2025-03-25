namespace Reverse_Words_in_a_String_III
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "Let's take LeetCode contest";
            Console.WriteLine(ReverseWords(s)); //Output: "s'teL ekat edoCteeL tsetnoc"
        }

        static public string ReverseWords(string s)
        {
            List<string> words = s.Split(' ',
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .ToList();

            for (int i = 0; i < words.Count; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray); 
            }

            return String.Join(' ', words);
        }
    }
}