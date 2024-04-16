namespace longest_distance_between_two_equal_cells
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region the logest distance between two equal digits in arr
            /*
                Consider an Array of Integer values with size N, having values as in this
                   Example

                   7	0	0	0	5	6	7	5	0	7	5	3

                   Your task will be to write a program find the longest distance between
                   Two equal cells. In this example. The distance is measured by the number
                   Of cells- for example, the distance between the first and the fourth cell is
                   2 (cell 2 and cell 3).
                   In the example above, the longest distance is between the first 7 and the
                   10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
                   And the 10th 7s.
                   Note:
                   - Array values will be taken from the user
                   - If you have input like 1111111 then the distance is the number of
                   Cells between the first and the last cell.
                */

            //int[] nums = new int[] { 2, 4, 6, 2, 4, 9, 6, 10, 2 };
            //int longestDistance = default; 
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length ; j++)
            //    {
            //        if (nums[i] == nums[j] && (( j - i ) > longestDistance ))
            //            longestDistance = ( j - i ) ;
            //    }
            //}
            //Console.WriteLine(longestDistance - 1 ); 
            #endregion

            Console.WriteLine($"long max value is : {long.MaxValue}");  // ==> 9223372036854775807
            Console.WriteLine($"int max value is : {int.MaxValue}");   // ==> 2147483647

            // long l = 9223372036854775807;
            long l = 2147483647;

            int i = 0;

            i = (int)l; // why doesn't it take max value of int and neglect the rest ? 

            Console.WriteLine($"the new value of i : {i}");  // ==> i = -1 
        }
    }
}
