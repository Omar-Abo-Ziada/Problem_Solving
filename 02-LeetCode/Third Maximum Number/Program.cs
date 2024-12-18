namespace Third_Maximum_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] nums = [1, 2, -2147483648]; // -2147483648
            //int[] nums = [1, 2]; // 1
            //int[] nums = [10, 21,30,2]; // 10
            //int[] nums = [1, -2147483648, 2]; // -2147483648
            int[] nums = [1, -2147483648]; // 1

            int thirdMax = ThirdMax(nums);

            Console.WriteLine(thirdMax);
        }



        public static int ThirdMax(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;

            int? firstMax = null;
            int? secondMax = null;
            int? thirdMax = null;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num == firstMax || num == secondMax || num == thirdMax)
                {
                    continue;
                }


                if (firstMax is null || num > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = num;
                }
                else if (secondMax is null || num > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }
                else if (thirdMax is null || num > thirdMax)
                {
                    thirdMax = num;
                }
            }

            return thirdMax ?? firstMax.Value;
        }






































        //static public int ThirdMax(int[] nums)
        //{
        //    if (nums is null || nums.Length == 0) return 0;

        //    int? firstMax = null;
        //    int? secondMax = null;
        //    int? thirdMax = null;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int num = nums[i];

        //        if (num == firstMax || num == secondMax || num == thirdMax)
        //        {
        //            continue;
        //        }

        //        if (firstMax == null || num > firstMax)
        //        {
        //            thirdMax = secondMax;
        //            secondMax = firstMax;
        //            firstMax = num;
        //        }
        //        else if (secondMax == null || num > secondMax)
        //        {
        //            thirdMax = secondMax;
        //            secondMax = num;
        //        }
        //        else if (thirdMax == null || num > thirdMax)
        //        {
        //            thirdMax = num;
        //        }
        //    }

        //    return thirdMax ?? firstMax.Value;
        //}


    }
}