namespace Ali_Papa_and_Puzzels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            D.Ali Baba and Puzzles
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //One day, Ali Baba had an easy puzzle that he couldn't solve. The puzzle consisted of 4
            // numbers and his task was to check whether he could get the fourth number using arithmetic operators (+,−,×
            //) between the other three numbers; so that each operator is used only once.

            //a□b□c = d
            //Can you solve this tricky puzzle for him?
            //Input
            //Only one line containing four numbers a
            //, b
            //, c
            // and d
            // (−109≤a, b, c≤109
            //), (−1018≤d≤1018
            //).

            //Output
            //Print "YES"(without quotes) if you get the fourth number using arithmetic operators, otherwise, print "NO"(without quotes).

            //Examples
            //inputCopy
            //3 4 5 23
            //outputCopy
            //YES
            //inputCopy
            //9 5 3 7
            //outputCopy
            //YES
            //inputCopy
            //1 2 3 1
            //outputCopy
            //NO 
            #endregion

            string[] inputs = Console.ReadLine().Split();

            long a = long.Parse(inputs[0]);
            long b = long.Parse(inputs[1]);
            long c = long.Parse(inputs[2]);

            long d = long.Parse(inputs[3]);

            //char add = '+';
            //char minus = '-';
            //char multiply = '*';

            if (a + b * c == d)
            {
                Console.WriteLine("YES");
            }
            else if(a + b - c == d)
            {
                Console.WriteLine("YES");
            }
            else if (a - b + c == d)
            {
                Console.WriteLine("YES");
            }
            else if (a - b * c == d)
            {
                Console.WriteLine("YES");
            }
            else if (a * b - c == d)
            {
                Console.WriteLine("YES");
            }
            else if (a * b + c == d)
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
