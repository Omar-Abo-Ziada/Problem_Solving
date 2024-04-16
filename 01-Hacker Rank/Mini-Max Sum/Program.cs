using System;
using System.Collections.Generic;

namespace Mini_Max_Sum
{
    internal class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }
            List<long> diffs = new List<long>(arr.Count);
            for (int i = 0; i < arr.Count; i++)
            {
                diffs.Add(sum - arr[i]);
            }
            diffs.Sort();
            Console.Write(diffs[0] + " ");
            Console.WriteLine(diffs[arr.Count - 1]);
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 }; // Example list of numbers
            miniMaxSum(numbers); // Call the miniMaxSum method with the list of numbers
        }
    }
}
