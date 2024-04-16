using System;

namespace Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            I.Lucky Numbers
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //A number of two digits is lucky if one of its digits is divisible by the other.

            //For example, 39, 82, and 55 are lucky, while 79 and 43 are not.

            //Given a number between 10 and 99, determine whether it is lucky or not.

            //Input
            //Only one line containing a single number N
            // (10≤N≤99)
            //.

            //Output
            //Print "YES" if the given number is lucky, otherwise print "NO".

            //Examples
            //inputCopy
            //39
            //outputCopy
            //YES
            //inputCopy
            //64
            //outputCopy
            //NO 
            #endregion

            if(int.TryParse(Console.ReadLine() ,out int number))
            {
                int first = number / 10 ;
                int second = number % 10 ;

                if(first == 0 || second == 0)
                    Console.WriteLine("YES");
                else if (first % second == 0 || second % first == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("Invalid input !");
            }
        }
    }
}
