namespace C._Choose_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*C. Choose Elements
  time limit per test1 second
  memory limit per test256 megabytes
  You are given an array a
   of n
   integers, and an integer k
  You can choose at most k
   elements and get their summation.

  What is the maximum summation you can get?

  Input
  The first line contains two integers n
   and k(1≤k≤n≤103)
   the number of elements in the array a
   and the maximum elements you can choose respectively.

  The second line contains n
   integers ai(−109≤ai≤109)
   the elements of the array a
  .

  Output
  Output the maximum summation you can get.

  Examples
  InputCopy
  2 2
  1 2
  OutputCopy
  3
  InputCopy
  2 1
  1 2
  OutputCopy
  2
  InputCopy
  3 3
  1 2 3
  OutputCopy
  6
  */ 
            #endregion

            string[] inputs = Console.ReadLine().Split();

            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            int[] nums = Array.ConvertAll(Console.ReadLine().Split() , int.Parse);

            //for (int i = 0; i < length; i++)
            //{
                
            //}


        }
        
    }
}