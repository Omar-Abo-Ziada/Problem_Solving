namespace U._Some_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*U. Some Sums
time limit per test2 seconds
memory limit per test256 megabytes
Given three numbers N, A, B. Print the summation of the numbers between 1 and N whose sum of digits is between A and B inclusive.

Input
Only one line containing three numbers N, A, B (1 ≤ N ≤ 104, 1 ≤ A ≤ B ≤ 36).

Output
Print a single line contains the answer according to the required above.

Examples
InputCopy
20 2 5
OutputCopy
84
InputCopy
10 1 2
OutputCopy
13
InputCopy
100 4 16
OutputCopy
4554
Note
In the first simple:

Among the numbers not greater than 20, the numbers whose sums of digits are between 2 and 5, are: 2,3,4,5,11,12,13,14 and 20.

So the answer is: 84.

*/
            #endregion

            string[] inputs = Console.ReadLine().Split();

            short N = short.Parse(inputs[0]);
            short A = short.Parse(inputs[1]);
            short B = short.Parse(inputs[2]);

            //Console.WriteLine($"{N} , {A} , {B}");

            int sum = 0;

            for (short i = 1; i <= N; i++)
            {
                sum += ValidateSum(i, A, B);
            }

            Console.WriteLine(sum);
        }

        private static int ValidateSum(short i, short A, short B)
        {
            short temp = i;

            int sum = 0;

            while (i > 0)
            {
                int digit = i % 10;

                sum += digit;

                i /= 10;
            }

            if (sum >= A && sum <= B)
            {
                //Console.WriteLine(temp);
                return temp;
            }
            else
            {
                return 0;
            }
        }
    }
}