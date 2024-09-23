namespace S._Max_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                                         * S. Max Split
                             time limit per test1 second
                             memory limit per test256 megabytes

                             Given a balanced string S
                              consists of ['R', 'L'] characters. Split it into maximum number of strings such that the new strings are also balanced.

                             Note:

                             Balanced strings are those who have equal quantities of 'L' and 'R' characters.
                             You can not remove or reorder the characters while making the new strings.
                             Input
                             Only one line contains a string S
                              (2≤|S|≤1000)
                              where |S| is the length of the string.

                             It's guaranteed that S
                              consists of only ['L', 'R'] letters, S
                              is balanced and |S|
                              is even.

                             Output
                             Print maximum number of balanced strings then the balanced strings in any order.

                             Examples
                             InputCopy
                             LLRRLLLRRR
                             OutputCopy
                             2
                             LLRR
                             LLLRRR
                             InputCopy
                             LLLRRR
                             OutputCopy
                             1
                             LLLRRR

             */

            string? S = Console.ReadLine();

            char[] charsArr = S.ToCharArray();

            int L_Counter = 0;
            int R_Counter = 0;

            int pairsCount = 0;

            List<string> pairs = new List<string>();    

            for (int i = 0; i < charsArr.Length; i++)
            {
                if (charsArr[i] == 'R')
                {
                    R_Counter++;
                }
                else
                {
                    L_Counter++;
                }

                if(L_Counter == R_Counter)
                {
                    pairsCount++;

                    string pair = new string(charsArr, i+1-L_Counter - R_Counter , R_Counter+L_Counter);

                    pairs.Add(pair);

                    R_Counter = 0;
                    L_Counter = 0;
                }
            }

            Console.WriteLine(pairsCount);

            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }
        }
    }
}