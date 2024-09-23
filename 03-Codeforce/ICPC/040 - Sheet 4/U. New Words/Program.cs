using System.Collections;

namespace U._New_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*U. New Words
time limit per test1 second
memory limit per test256 megabytes
Given a string S
. Print number of times that "EGYPT" word can be formed from S
's characters.

Note: Case of the letters doesn't matter. For example: "Egypt", "egypt" and "eGyPt" are the same.

Input
Only one line contains a string S(1≤|S|≤106)
 where |S| is the length of the string and it consists of lowercase and uppercase English letters.

Output
Print the answer required above.

Examples
InputCopy
EgYpTaz
OutputCopy
1
InputCopy
pemigdbeigyypetet
OutputCopy
2
*/

            string S = Console.ReadLine();

            int e_Counter = 0;
            int g_Counter = 0;
            int y_Counter = 0;
            int p_Counter = 0;
            int t_Counter = 0;

            int fullWordCounter = 0;

            char[] charsArr = S.ToLower().ToCharArray();

            for (int i = 0; i < charsArr.Length; i++)
            {
                if (charsArr[i] == 'e')
                {
                    e_Counter++;
                }

                if (charsArr[i] == 'g')
                {
                    g_Counter++;
                }

                if (charsArr[i] == 'y')
                {
                    y_Counter++;
                }

                if (charsArr[i] == 'p')
                {
                    p_Counter++;
                }

                if (charsArr[i] == 't')
                {
                    t_Counter++;
                }
            }

            fullWordCounter = Math.Min(e_Counter , Math.Min(g_Counter , Math.Min(y_Counter , Math.Min(p_Counter , t_Counter))));

            Console.WriteLine(fullWordCounter);
        }
    }
}