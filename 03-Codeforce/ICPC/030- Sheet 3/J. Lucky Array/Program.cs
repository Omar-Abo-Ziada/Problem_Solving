namespace J._Lucky_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
              * J. Lucky Array
 time limit per test1 second
 memory limit per test256 megabytes
 Given a number N and an array A of N numbers. Determine if the array is lucky or not.

 Note: the array is lucky if the frequency (number of occurrence) of the minimum element is odd.

 Input
 First line contains a number N (2 ≤ N ≤ 1000) number of elements.

 Second line contains N numbers ( - 105 ≤ Ai ≤ 105).

 Output
 Print "Lucky" (without quotes) if the frequency of the minimum element is odd, otherwise print "Unlucky"(without quotes).

 Examples
 InputCopy
 5
 8 8 9 5 9
 OutputCopy
 Lucky
 InputCopy
 5
 3 3 3 5 3
 OutputCopy
 Unlucky
 Note
 First Example :

 minimum element is 5 and its frequency is 1 and it's ODD so the array is lucky.

 Second Example :

 minimum element is 3 and its frequency is 4 and it's EVEN so the array is not lucky.


              */
            #endregion

            short N = short.Parse(Console.ReadLine());

            int[] nums = new int[N];

            string[] inputs = Console.ReadLine().Split();

            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            int frequency = GetMinNumFrequency(nums);

            if (frequency % 2 != 0 ) 
            {
                Console.WriteLine("Lucky");
            }
            else
            {
                Console.WriteLine("Unlucky");
            }
        }

        private static int GetMinNumFrequency(int[] nums)
        {
            int min = nums[0];

            for(int i = 0; i < nums.Length ; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            int frequency = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == min)
                {
                    frequency ++;
                }
            }

            return frequency;
        }
    }
}