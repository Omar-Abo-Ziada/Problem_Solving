namespace D._Positions_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*

              D. Positions in array
             time limit per test1 second
             memory limit per test256 megabytes
             Given a number N and an array A of N numbers. Print all array positions that store a number less than or equal to 10 and the number stored in that position.

             Input
             First line contains a number N (2 ≤ N ≤ 1000) number of elements.

             Second line contains N numbers (-105  ≤  Ai  ≤  105).

             it's guaranteed that there is at least one number in array less than or equal to 10.

             Output
             For each number in the array that is equal to or less than 10 print a single line contains "A[i] = X", where i is the position in the array and X is the number stored in the position.

             Example
             InputCopy
             5
             1 2 100 0 30
             OutputCopy
             A[0] = 1
             A[1] = 2
             A[3] = 0
             */
            #endregion

            short n = short.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);

                if (nums[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {nums[i]}");
                }
            }
        }
    }
}
