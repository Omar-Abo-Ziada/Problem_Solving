namespace Reverse_the_order_of_the_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Given a list of space separated words, reverse the order of the words.

            Input: this is a test		Output: test a is this
            Input: all your base		Output: base your all
            Input: Word			Output: Word
            >> Check the Split Function (Member in String Class)
            Output will be a Single Console.WriteLine Statment
            
             */

            string sentence = "this is a test";
            
            string[] words  = sentence.Split(' ');

            for (int i = words.Length-1 ; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            /*or this way to display : 
             
             for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[words.Length-1-i]);
            }
             
             */
        }
    }
}
