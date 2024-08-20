namespace H._Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*
               H. Sorting
  time limit per test1 second
  memory limit per test64 megabytes
  Given a number N and an array A of N numbers. Print the numbers after sorting them.

  Note:

  Don't use built-in-functions.
  try to solve it with bubble sort algorithm or Selection Sort.
  for more information watch : https://www.youtube.com/watch?v=EnodMqJuQEo.
  Input
  First line contains a number N (0 < N < 103) number of elements.

  Second line contains N numbers ( - 100 ≤ Ai ≤ 100).

  Output
  Print the numbers after sorting them.

  Examples
  InputCopy
  3
  3 1 2
  OutputCopy
  1 2 3 
  InputCopy
  4
  5 2 7 3
  OutputCopy
  2 3 5 7 

               */
            #endregion

            short n = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            short[] nums = new short[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = short.Parse(inputs[i]);
            }

            SelectionSort(nums);
            //BubbleSort(nums);

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }

        private static void SelectionSort(short[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                if (minIndex != i) // Swap only if a new minimum is found
                {
                    Swap(ref nums[i], ref nums[minIndex]);
                }
            }
        }

        private static void BubbleSort(short[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                bool sorted = true;

                for (int j = 0; j < nums.Length - i - 1 ; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        Swap(ref nums[j], ref nums[j+1]);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
        }

        private static void Swap(ref short x, ref short y)
        {
            short temp = x;
            x = y;
            y = temp;
        }
    }
}