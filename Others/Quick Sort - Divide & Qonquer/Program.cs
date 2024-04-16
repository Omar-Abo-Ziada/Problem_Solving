namespace Quick_Sort___Divide___Qonquer
{
    internal class Program
    {
        static List<int> QuickSort(List<int> nums)
        {
            List<int> result = new List<int>();

            if (nums.Count < 2 )
            {
                return nums;
            }
            else
            {
                int pivot = nums[0];

                List<int> less = new List<int>();
                List<int> greater = new List<int>();
                foreach ( int i in nums )
                {
                    if ( i < pivot )
                    {
                        less.Add(i);
                    }
                    else if( i > pivot )
                    {
                        greater.Add(i);
                    }
                }

                result.AddRange(QuickSort( less ));
                result.Add(pivot);
                result.AddRange(QuickSort(greater));

                return result;
            }
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 4,1,7 , 3 , 2 ,10};
            List<int> result = QuickSort(nums);
            foreach ( int i in result )
            {
                Console.Write($"{i} \t");
            }
        }
    }
}
