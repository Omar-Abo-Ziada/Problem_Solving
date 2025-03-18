namespace Two_Sum_II___Input_array_is_sorted;

public class Program
{
    static void Main(string[] args)
    {
        int[] result1 = TwoSum([2, 7, 11, 15] , 9);
        Console.WriteLine(result1[0] + " " + result1[1]); // 1 , 2

        int[] result2 = TwoSum([2, 3, 4], 6);
        Console.WriteLine(result2[0] + " " + result2[1]); // 1 , 3

        int[] result3 = TwoSum([-1,0], -1);
        Console.WriteLine(result3[0] + " " + result3[1]); // 1 , 2
    }

    static public int[] TwoSum(int[] numbers, int target)
    {
        int[] result = new int[2];

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];
            if (currentSum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }
            else if (currentSum > target)
            {
                result[0] = left + 1;
                right--;
            }
            else
            {
                result[1] = right + 1;
                left++;
            }
        }
        return result;
    }
}