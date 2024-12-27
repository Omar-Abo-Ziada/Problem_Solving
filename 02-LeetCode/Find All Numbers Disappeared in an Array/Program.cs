namespace Find_All_Numbers_Disappeared_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1,1];

            List<int> result = FindDisappearedNumbers(nums).ToList();

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        static public IList<int> FindDisappearedNumbers(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return new List<int>();
            }

            for(int i = 0; i < nums.Length ; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] > 0) // => not visited
                {
                    nums[index] = -nums[index]; // => mark as visited
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                   result.Add(i + 1);
                }
            }

            return result;

        }
    }
}