namespace F._Break_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
             F. Break Number
time limit per test1 second
memory limit per test256 megabytes
Let's define f(x)
 as the number of times at which the integer x
 can be divided by 2
.

You are given N
 numbers, and you should print the maximum f(x)
 among all these numbers.

Input
The first line contains one number N
 (1≤N≤105
).

The second line contains N
 space-separated numbers where each number is between 1
 and 1018
 (inclusive).

Output
Print the maximum f(x)
 among all numbers.

Examples
InputCopy
3
18 24 7
OutputCopy
3
InputCopy
4
14 7 9 5
OutputCopy
1
Note
In the first test case:

f(18)
 is equal to 1
; because we can divide 18
 by 2
 resulting in 9
, but we cannot divide 9
 by 2
 (9
 is not divisible by 2)
.
f(24)
 is equal to 3
; because we can divide 24
 by 2
 resulting in 12
; again we can divide 12
 by 2
 (12
 is divisible by 2
) resulting in 6
; again we can divide 6
 by 2
 (6
 is divisible by 2
) resulting in 3
, but we cannot divide 3
 by 2
 (3
 is not divisible by 2
); so we could divide 24
 three times.
f(7)
 is equal to 0
; because we cannot divide 7
 by 2
.*/
            #endregion

            int numOfTestCases = int.Parse(Console.ReadLine());

            long[] nums = new long[numOfTestCases];

            int maxTimesAnyNumDividableByTwo = 0;

            string[] numsInputs = Console.ReadLine().Split();

            for (int i = 0; i < numOfTestCases; i++)
            {
                nums[i] = long.Parse(numsInputs[i]);

                int times = CalcTimesDividableByTwo(nums[i]);

                if (times > maxTimesAnyNumDividableByTwo)
                {
                    maxTimesAnyNumDividableByTwo = times;
                }
            }

            Console.WriteLine(maxTimesAnyNumDividableByTwo);
        }

        private static int CalcTimesDividableByTwo(long num)
        {
            int times = 0;

            while (num % 2 == 0)
            {
                times++;
                num /= 2;
            }

            return times;
        }
    }
}