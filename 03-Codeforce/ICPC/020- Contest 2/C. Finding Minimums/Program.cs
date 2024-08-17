using System;
using System.Collections.Generic;

namespace C._Finding_Minimums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int N = int.Parse(inputs[0]);
            int K = int.Parse(inputs[1]);

            string[] numsInputs = Console.ReadLine().Split();
            List<int> nums = new List<int>(N);

            for (int i = 0; i < N; i++)
            {
                nums.Add(int.Parse(numsInputs[i]));
            }

            List<List<int>> groups = new List<List<int>>();
            for (int i = 0; i < N; i += K)
            {
                List<int> group = new List<int>();
                for (int j = i; j < i + K && j < N; j++)
                {
                    group.Add(nums[j]);
                }
                groups.Add(group);
            }

            foreach (var group in groups)
            {
                int min = int.MaxValue;
                foreach (var num in group)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                Console.Write(min + " ");
            }
        }
    }
}
