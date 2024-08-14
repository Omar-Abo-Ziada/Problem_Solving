using System.Reflection.Metadata;

namespace X.Convert_To_Decimal_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            int[] numbers = new int[NumberOfTestCases];

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                //int num = int.Parse(Console.ReadLine());

                int onesCount = CountOnesInBinaryRepresentaionForDecimal(numbers[i]);

                double decimalNum = CalculateDeciamlForBinaryOnesOnly(onesCount);

                Console.WriteLine(decimalNum);
            }
        }

        private static int CountOnesInBinaryRepresentaionForDecimal(int num)
        {
            int onesCount = 0;

            while (num > 0)
            {
                if (num % 2 != 0)
                {
                    onesCount++;
                }

                num /= 2;
            }

            return onesCount;
        }

        private static double CalculateDeciamlForBinaryOnesOnly(int onesCount)
        {
            double decimalNum = 0;

            for (int i = 0; i < onesCount; i++)
            {
                decimalNum += Math.Pow(2, (double)i);
            }

            return decimalNum;
        }
    }
}