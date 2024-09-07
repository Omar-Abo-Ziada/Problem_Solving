namespace F._Front___End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            /*F. Front - End
            //time limit per test1 second
            //memory limit per test256 megabytes
            //You are given an array a
            // of n
            // integers, your task is to print the first (front) element then remove it, then print the last(end) element then remove it, and so on until the array becomes empty.

            //Input
            //The first line contains an integer n(1≤n≤105)
            // the number of elements in the array a

            //The second line contains n
            // integers ai(−109≤ai≤109)
            // the elements of the array a
            //.

            //Output
            //Print the array a
            // with the required order.

            //Example
            //InputCopy
            //5
            //1 2 3 4 5
            //OutputCopy
            //1 5 2 4 3*/ 
            #endregion

            int N = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            List<int> list = new List<int>();

            for (int i = 0; i < N; i++)
            {
                list.Add(int.Parse(inputs[i]));
            }

            FrontEnd(list);
        }

        private static void FrontEnd(List<int> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                Console.Write($"{list[left]} {list[right]} ");

                left++;
                right--;
            }

            if (left == right) 
            {
                Console.WriteLine($"{list[left]}");
            }
        }
    }
}