namespace Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits1 = [1, 2, 3]; // expected: [1, 2, 4]
            int[] digits2 = [4, 3, 2, 1]; // expected: [4, 3, 2, 2]
            int[] digits3 = [9]; // expected: [1, 0]
            int[] digits4 = [9, 9]; // expected: [1, 0,0]

            digits1 = PlusOne(digits1);
            digits2 = PlusOne(digits2);
            digits3 = PlusOne(digits3);
            digits4 = PlusOne(digits4);

            foreach (var item in digits1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            foreach (var item in digits2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in digits3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in digits4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        static public int[] PlusOne(int[] digits)
        {
            if (digits is null || digits.Length == 0) return null;

            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1]++;

                return digits;
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        digits = new int[digits.Length + 1];
                        digits[0] = 1;
                        return digits;
                    }
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }

            return digits;

        }
    }
}
