namespace Two_numbers
{
    internal class Program
    {
        //static List<int> QuickSort(List<int> nums)
        //{
        //    List<int> result = new List<int>();

        //    if (nums.Count < 2)
        //    {
        //        return nums;
        //    }
        //    else
        //    {
        //        int pivot = nums[0];

        //        List<int> less = new List<int>();
        //        List<int> greater = new List<int>();
        //        foreach (int i in nums)
        //        {
        //            if (i < pivot)
        //            {
        //                less.Add(i);
        //            }
        //            else if (i > pivot)
        //            {
        //                greater.Add(i);
        //            }
        //        }

        //        result.AddRange(QuickSort(less));
        //        result.Add(pivot);
        //        result.AddRange(QuickSort(greater));

        //        return result;
        //    }
        //}

        static void Main(string[] args)
        {
            //List<int> nums = new List<int>() { 5,10,2,1,8,12 };
            //List<int> result = QuickSort(nums);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            string[] inputs = Console.ReadLine().Split();
            float x = float.Parse(inputs[0]);
            float y = float.Parse(inputs[1]);

            Console.WriteLine($"floor {x} / {y} = {Math.Floor(x / y)}");
            Console.WriteLine($"ceil {x} / {y} = {Math.Ceiling(x / y)}");
            Console.WriteLine($"round {x} / {y} = {Math.Round(x / y, MidpointRounding.AwayFromZero)}");
        }
    }
}

