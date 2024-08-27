namespace N._Check_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*N. Check Code
             * 
             * 
     time limit per test1 second
     memory limit per test256 megabytes


     Given two numbers A, B and a code S consisting of digits (0,1,2,...,9) and a symbol '-'.

     Determine if the code follows the following rules or not:

     The position A + 1 in the code is the symbol '-'.
     All other characters are one of the following digits: (0,1,2,...,9).
     Input
     First line contains two numbers A, B (1 ≤ A, B ≤ 10).

     Second line contains S (|S| = A + B + 1) and consists of '-' and digits from 0 through 9.

     Output
     Print "Yes" if the code S follows the above rules otherwise, print "No".

     Examples
     InputCopy
     3 3
     269-665
     OutputCopy
     Yes
     InputCopy
     1 1
     12-
     OutputCopy
     No
     InputCopy
     1 2
     7444
     OutputCopy
     No
     Note
     First example:

     The (A+1)-th character of code is '-', and the other characters are digits from '0' through '9', so it follows the format.

     */
            #endregion

            string[] inputs = Console.ReadLine().Split();

            short A = short.Parse(inputs[0]);
            short B = short.Parse(inputs[1]);

            string symbol = Console.ReadLine();

            if (symbol[(A+1)-1] == '-' && symbol.Length == A + B +1)
            {
                bool isValid = true;

                for (int i = 0; i < symbol.Length; i++)
                {
                    if (i != A && !char.IsDigit(symbol[i]))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}