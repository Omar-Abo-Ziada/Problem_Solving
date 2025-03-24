namespace Reverse_Words_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords(" The Sky Is blue "));
            Console.WriteLine(ReverseWords("  hello world  "));
            Console.WriteLine(ReverseWords("a good   example"));

        }

        static public string ReverseWords(string s)
        {
            List<string> stringsList = s.Trim()
                                   .Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();

            int left = 0;
            int right = stringsList.Count - 1;

            while (left < right)
            {
                string temp = stringsList[left];
                stringsList[left] = stringsList[right];
                stringsList[right] = temp;
                left++;
                right--;
            }

            return String.Join(' ',stringsList);
        }
    }
}