namespace Single_Number;

internal class Program
{
    public static int SingleNumber(int[] nums)
    {
        int single = 0;

        foreach (int num in nums)
        {
            single ^= num;
        }

        return single;

    }
    static void Main(string[] args)
    {
        SingleNumber([4, 1, 2, 1, 2]);
    }
}