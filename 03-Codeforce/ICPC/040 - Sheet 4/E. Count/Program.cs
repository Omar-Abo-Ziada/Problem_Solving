    namespace E._Count
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string S = Console.ReadLine();

                int[] nums = new int[S.Length];

                int sum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = int.Parse(S[i].ToString());
                    sum += nums[i];
                }

                Console.WriteLine(sum);
            }
        }
    }