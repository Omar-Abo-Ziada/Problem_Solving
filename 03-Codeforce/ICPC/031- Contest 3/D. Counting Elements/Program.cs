namespace D._Counting_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*D. Counting Elements
  time limit per test1 second
  memory limit per test256 megabytes
  You are given an array a
   of n
   integers, count the number of element ai
   in the array such that ai+1
   is also exists in the array a
   .

  If there're duplicates in a
  , count them separately.

  Input
  The first line contains an integer n(1≤n≤103)
   the number of elements in the array a

  The second line contains n
   integers ai(0≤Xi≤103)
   the elements of the array a
  .

  Output
  output the number of elements as descriped above.

  Examples
  InputCopy
  3
  4 4 5
  OutputCopy
  2
  InputCopy
  3
  1 2 3
  OutputCopy
  2
  InputCopy
  8
  1 1 3 3 5 5 7 7
  OutputCopy
  0
  InputCopy
  6
  1 3 2 3 5 0
  OutputCopy
  3*/ 
            #endregion

            int N = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(Console.ReadLine().Split() , int.Parse);

            int counter = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (nums[i]+1 == nums[j])
                    {
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}