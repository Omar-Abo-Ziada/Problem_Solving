namespace N._Numbers_Histogram
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            #region doc
            /*
                                * N. Numbers Histogram
                   time limit per test1 second
                   memory limit per test256 megabytes
                   Given 3 lines of input described as follow:

                   First line contains a symbol S
                   .
                   Second line contains a number N
                   .
                   Third line contains N
                    numbers.
                   For each number Xi
                    in the N
                    numbers print a new line that contains the symbol S
                    repeated Xi
                    time.

                   Input
                   The first line contains a symbol S
                    can be (+,−,∗,/)
                   .

                   The second line an number N
                    (1≤N≤50)
                   .

                   The third line contains N
                    numbers (1≤Xi≤100)
                   .

                   Output
                   Print the answer required above.

                   Example
                   InputCopy
                   +
                   5
                   5 2 4 3 7
                   OutputCopy
                   +++++
                   ++
                   ++++
                   +++
                   +++++++
                   Note
                   Don't print any extra spaces after symbol S
                   .
                */
            #endregion

            char s = Console.ReadLine().First();
            short n = short.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split();

            int[] numsArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numsArr[i] = int.Parse(nums[i]);
            }

            //Console.WriteLine($"S:{s}");
            //Console.WriteLine($"n:{n}");
            //Console.WriteLine("nums string: " + string.Join(" ", nums));

            //foreach (var item in numsArr)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0 ; i < n; i++)
            {
                PrintSympolLine(numsArr[i], s);
            }
        }

        internal static void PrintSympolLine(int n, char s)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine();
        }
    }
}
