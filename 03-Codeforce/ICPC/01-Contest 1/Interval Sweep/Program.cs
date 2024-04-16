using System.ComponentModel;

namespace Interval_Sweep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            E.Interval Sweep
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //Given two numbers a
            // and b
            //. You have to answer with "YES" if there is a non - empty interval consisting of numbers from l
            // to r
            // (l, l + 1, l + 2, ..., r
            //) with a odd numbers and b even numbers, or "NO" otherwise.

            //Input
            //Only one line containing two numbers a
            // and b
            // (0≤a,b≤100
            //)the number of odd numbers and the number of even numbers in the interval respectively.

            //Output
            //Print "YES" or "NO" as described in the statement.

            //Examples
            //inputCopy
            //2 3
            //outputCopy
            //YES
            //inputCopy
            //3 1
            //outputCopy
            //            NO
            //Note
            //Example 1 :

            //some valid intervales that contain 2
            // odd numbers and 3
            // even numbers can be

            //l = 6,r = 10
            // contains numbers(6,7,8,9,10)
            //.

            //l = 14,r = 18
            // contains numbers(14,15,16,17,18) 
            #endregion

            string[] inputs = Console.ReadLine().Split();

            if (int.TryParse(inputs[0],out int a) & int.TryParse(inputs[1],out int b))
            {

            }
            else
            {
                Console.WriteLine("Invalid Input !");
                Console.WriteLine("Enter one num then space then another number .");
            }

            if (( a -b == 1 ) || ( b - a == 1) || (a == b && a!=0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
