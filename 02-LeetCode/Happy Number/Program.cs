using System.Collections.Generic;

namespace Happy_Number;

internal class Program
{

    public static bool IsHappy(int n)
    {

        HashSet<int> seen = new();

        while (n != 1)
        {
            if (!seen.Contains(n))
            {
                seen.Add(n);
                n = GetSquareDigitsSum(n);
            }
            else
            {
                return false;
            }
        }

        return true;

    }

    public static int GetSquareDigitsSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit * digit;
            number /= 10;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsHappy(2));
    }
}
