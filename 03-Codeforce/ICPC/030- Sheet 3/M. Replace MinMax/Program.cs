namespace M._Replace_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*M. Replace MinMax
  time limit per test1 second
  memory limit per test256 megabytes
  Given a number N and an array A of N numbers. Print the array after doing the following operations:

  Find minimum number in these numbers.
  Find maximum number in these numbers.
  Swap minimum number with maximum number.
  Input
  First line contains a number N (2 ≤ N ≤ 1000) number of elements.

  Second line contains N numbers ( - 105 ≤ Ai ≤ 105)

  It's guaranteed that all numbers are distinct.

  Output
  Print the array after the replacement operation.

  Example
  InputCopy
  5
  4 1 3 10 8
  OutputCopy
  4 10 3 1 8 */
            #endregion

            short N = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[N];

            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int maxIndex = 0;
            int max = nums[0];

            int minIndex = 0;
            int min = nums[0];

            for (int i = 0; i < N; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    minIndex = i;
                }

                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }

            int temp = nums[maxIndex];
            nums[maxIndex] = nums[minIndex];
            nums[minIndex] = temp;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}