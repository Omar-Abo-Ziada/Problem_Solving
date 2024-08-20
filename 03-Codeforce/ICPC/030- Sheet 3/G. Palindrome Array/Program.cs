namespace G._Palindrome_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split();

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(inputs[i]);
            }

            bool isPalindrom = true;

            for (int i = 0; i < n /2; i++)
            {  // 0              4
                // 1              3
                if (nums[i] != nums[n-i-1])
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
