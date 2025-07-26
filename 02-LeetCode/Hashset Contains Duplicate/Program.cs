namespace Hashset_Contains_Duplicate;

internal class Program
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> hashset = new List<int>();
        foreach (int num in nums)
        {
            if (hashset.Contains(num))
            {
                return true;
            }
            hashset.Add(num);
        }
        return false;
    }

    static void Main(string[] args)
    {
    }
}