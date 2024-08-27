namespace K._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*K. Sum Digits
time limit per test2 seconds
memory limit per test256 megabytes
Given a number N and an array A of N digits (not separated by space). Print the summation of these digits.

Input
First line contains a number N (1  ≤  N  ≤  106) number of digits.

Second line contains N digits (0 ≤ Ai ≤ 9).

Output
Print the summation of these digits.

Example
InputCopy
5
13305
OutputCopy
12
Note
First Example :

1 + 3 + 3 + 0 + 5 = 12 .

*/

            #endregion

            int n = int.Parse(Console.ReadLine());

            string digits = Console.ReadLine();

            int sum = 0;

            // Sum all the digits
            foreach (char digit in digits)
            {
                int num = int.Parse(digit.ToString());

                //Console.WriteLine(num);

                sum += num;
            }

            // Output the result
            Console.WriteLine(sum);
        }
    }
}