using static System.Net.Mime.MediaTypeNames;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;
using System.ComponentModel.Design;

namespace I._Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            I.Palindrome
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //Given a number N
            //.Print 2 lines that contain the following respectively:

            //Print N
            // in a reversed order and not leading zeroes.
            //If N
            // is a palindrome number print "YES" otherwise, print "NO.
            //Note:

            //            A palindrome number is a number that reads the same forward or backward.

            //For example: 12321, 101 are palindrome numbers, while 1201, 221 are not.

            //A leading zero is any 0 digit that comes before the first nonzero digit in a number for example : numbers(005, 01, 0123, 02, 000250) are leading zeroes but(5, 123, 20, 2500) not leading zeroes numbers.

            //Input
            //Only one line containing a number N
            // (1≤N≤107)
            //.

            //Output
            //Print the answer required above.

            //Examples
            //inputCopy
            //12121
            //outputCopy
            //12121
            //YES
            //inputCopy
            //160
            //outputCopy
            //61
            //NO
            //        } 
            #endregion


            string input = Console.ReadLine();

            char[] inputArr = input.ToCharArray();

            bool isPalindrom = true;
            for(int i = 0; i < inputArr.Length/2; i++)
            {
                if (inputArr[i] != inputArr[inputArr.Length-1-i])
                    isPalindrom = false;
            }

            Array.Reverse(inputArr);
            string result = new string(inputArr);
            string trimmedResult = result.Trim('0');

            if (isPalindrom)
            {
                Console.WriteLine(trimmedResult);
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine(trimmedResult);
                Console.WriteLine("NO");
            }
        }
    }
}
