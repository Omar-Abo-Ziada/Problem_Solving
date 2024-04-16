namespace A._1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            A. 1 to N
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //Given a number N. Print numbers from 1 to N in separate lines.

            //Input
            //Only one line containing a number N(1 ≤ N ≤ 103).

            //Output
            //Print N lines according to the required above.

            //Example
            //inputCopy
            //5
            //outputCopy
            //1
            //2
            //3
            //4
            //5 
            #endregion

            int size = int.Parse(Console.ReadLine());

            for(int i = 1; i <= size; i++)
                Console.WriteLine(i);

        }
    }
}
