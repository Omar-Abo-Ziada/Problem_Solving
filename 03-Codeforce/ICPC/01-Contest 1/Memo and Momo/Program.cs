namespace Memo_and_Momo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proplem doc

            /*
                         B. Memo and Momo
            time limit per test1 second
            memory limit per test256 megabytes
            inputstandard input
            outputstandard output
            Memo and Momo are playing a game. Memo will choose a positive number a
            , and Momo will choose a positive number b
            .

            Your task is to tell them who will win according to the following rules:

            If both a
             and b
             are divisible by k
            , both of them win and you should print "Both".
            If a
             is divisible by k
             but b
             isn't, Memo wins and you should print "Memo".
            If b
             is divisible by k
             but a
             isn't, Momo wins and you should print "Momo".
            If both a
             and b
             are not divisible by k
            , no one wins and you should print "No One".
            Input
            Only one line containing three positive numbers a
            , b
             and k
             (1≤a,b,k≤1018
            ).

            Output
            Print the answer as described in the statement.

            Examples
            inputCopy
            15 7 3
            outputCopy
            Memo
            inputCopy
            22 10 2
            outputCopy
            Both

             */
            #endregion

            string[] inputs = Console.ReadLine().Split();

            long a = long.Parse(inputs[0]);
            long b = long.Parse(inputs[1]);
            long k = long.Parse(inputs[2]);

            if(a % k == 0 && b % k == 0)
                Console.WriteLine("Both");

            else if (b % k == 0)
                Console.WriteLine("Momo");

            else if (a % k == 0)
                Console.WriteLine("Memo");

            else
                Console.WriteLine("No One");
        }
    }
}
