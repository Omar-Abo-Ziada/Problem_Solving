using Microsoft.VisualBasic;

namespace Merge_Strings_Alternately
{
    internal class Program
    {
        static public string MergeAlternately(string word1, string word2)
        {
            int totalLength = word1.Length + word2.Length;
            char[] result = new char[totalLength] ;
            string biggerWord;
            string smallerWord;

            if (word1.Length > word2.Length)
            {
                biggerWord = word1;
                smallerWord = word2;
            }
            else
            {
                biggerWord = word2;
                smallerWord = word1;
            }

            for (int i = 0; i < smallerWord.Length * 2 ; i+=2)
            {
                int j = 0 ;
                result[i] += smallerWord[j];
                j++;
            }
            for (int i = 1; i < totalLength;)
            {

                int j = 0;
                result[i] += biggerWord[j];
                j++;
                if(i<=smallerWord.Length*2)
                    i++;

                i += 2;
            }
           
            return new string(result);
        }
        static void Main(string[] args)
        {
            #region problem documentation
            //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

            //Return the merged string.
            //            Example 1:

            //Input: word1 = "abc", word2 = "pqr"
            //Output: "apbqcr"
            //Explanation: The merged string will be merged as so:
            //word1: a b   c
            //            word2:    p q   r
            //merged: a p b q c r
            //Example 2:

            //Input: word1 = "ab", word2 = "pqrs"
            //Output: "apbqrs"
            //Explanation: Notice that as word2 is longer, "rs" is appended to the end.
            //word1: a b
            //word2: p q   r s
            //merged: a p b q   r s
            //Example 3:

            //Input: word1 = "abcd", word2 = "pq"
            //Output: "apbqcd"
            //Explanation: Notice that as word1 is longer, "cd" is appended to the end.
            //word1: a b   c d
            //word2: p q
            //merged: a p b q c d



            //Constraints:

            //            1 <= word1.length, word2.length <= 100
            //word1 and word2 consist of lowercase English letters.
            #endregion

            string word1 = "Omar"; 
            string word2 = "Emad";
            string result1 = MergeAlternately(word1 , word2);
            Console.WriteLine(result1);




        }
    }
}
