namespace Z._Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*Z. Binary Search
   time limit per test1 second
   memory limit per test256 megabytes
   Given 2 numbers N
    and Q
   , array A of N numbers and Q queries each one contains a number X
   .

   For each query print a single line that contains "found" if the number X
    exists in array A
    otherwise, print "not found".

   Input
   First line contains two numbers N
   , Q
    (1≤N,Q≤105)
   .

   Second line contains N
    numbers (1≤Ai≤109)
   .

   Next Q
    lines contains X
    (1≤X≤109)
   .

   Output
   Print the answer for each query in a single line.

   Example
   InputCopy
   5 3
   1 5 4 3 2
   5
   3
   6
   OutputCopy
   found
   found
   not found
   */
            #endregion

            // Sorted array
            //int[] array = { 1, 3, 5, 7, 9, 11, 13 };

            string[] sizes = Console.ReadLine().Split();

            int N = int.Parse(sizes[0]);
            int Q = int.Parse(sizes[1]);

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            // have to use QuickSort for time efficency (O(N log(N))) not N2 like in bubble and selection
            // use the built-in method for now untill implement it manually
            Array.Sort(nums);
            //SelectionSort(nums);
            //BubbleSort(nums);

            int[] targets = new int[Q];

            for (int i = 0; i < Q; i++)
            {
                targets[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Q; i++)
            {
                int result = BinarySearch(nums, targets[i]);

                if (result != -1)
                {
                    Console.WriteLine($"found");
                }
                else
                {
                    Console.WriteLine("not found");
                }
            }

        }

        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid; // Target found
                }

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        private static void SelectionSort(int[] nums)
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

        private static void BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                bool sorted = true;

                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(ref nums[j], ref nums[j + 1]);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}