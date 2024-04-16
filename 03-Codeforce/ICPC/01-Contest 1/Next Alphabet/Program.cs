using System.Diagnostics.Metrics;

namespace Next_Alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            C.Next Alphabet
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //Given a lowercase alphabet character.You have to print the next character in the alphabet.

            //Input
            //Only one line containing a lowercase English letter C
            //.

            //Output
            //Print the next letter to C
            // in the alphabet.

            //Example
            //            inputCopy
            //a
            //outputCopy
            //b
            //Note
            //The next letter to z is a. 
            #endregion

            char c = Console.ReadLine()[0];

            int asciiValue = Convert.ToInt32(c);

            if(asciiValue == 122)
            {
                asciiValue = 97;
            }
            else
            {
                asciiValue++;
            }

            char result = Convert.ToChar(asciiValue);

            Console.WriteLine(result);
        }
    }
}
