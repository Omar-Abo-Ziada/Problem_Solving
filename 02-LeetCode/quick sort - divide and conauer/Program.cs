namespace quick_sort___divide_and_conauer
{
    internal class Program
    {
        static List<int> QuickSort(List<int> nums)
        {
            List<int> result = new List<int> ();
            
            if(nums.Count < 2)
            {
                return nums;
            }
            else
            {
                int pivot = nums[0];

                List<int> less = new List<int>();
                foreach (int x in nums)
                {
                    less.Add(x);
                }

                List<int> greater = new List<int>();
                foreach (int x in nums)
                {
                    greater.Add(x);
                }

                result = QuickSort(less);
                result.Add(pivot);
                result.AddRange(greater);

                return result;
            }
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() {2,1,4};
            List<int> result = QuickSort(nums);
            Console.WriteLine(result);
        }
    }
}
