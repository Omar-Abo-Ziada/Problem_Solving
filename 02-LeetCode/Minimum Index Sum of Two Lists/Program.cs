namespace Minimum_Index_Sum_of_Two_Lists;

internal class Program
{
    static public string[] FindRestaurant(string[] list1, string[] list2)
    {
        if (list1 is null || list2 is null || list1.Length == 0 || list2.Length == 0) return [];

        Dictionary<string, int> dic1 = new();
        Dictionary<string, int> dic2 = new();

        for (int i = 0; i < list1.Length; i++)
        {
            string str1 = list1[i];
            dic1.Add(str1, i);
        }

        for (int i = 0; i < list2.Length; i++)
        {
            string str2 = list2[i];
            dic2.Add(str2, i);
        }

        List<string> result = new();
        int minIndexSum = int.MaxValue;
        foreach (KeyValuePair<string, int> pair1 in dic1)
        {
            if (dic2.ContainsKey(pair1.Key))
            {
                int currentIndexSum = pair1.Value + dic2[pair1.Key];
                if (currentIndexSum < minIndexSum)
                {
                    minIndexSum = currentIndexSum;

                    result.Clear();
                    result.Add(pair1.Key);

                }
                else if (currentIndexSum == minIndexSum)
                {
                    result.Add(pair1.Key);
                }
            }
        }

        return result.ToArray();

    }
    static void Main(string[] args)
    {
        //Example 1:
        //Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
        //Output: ["Shogun"]
        //Explanation: The only restaurant that appears in both lists is "Shogun".
        string[] result = FindRestaurant(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] { "Tapioca Express2", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
        Console.WriteLine(string.Join(", ", result));

        //Example 2:
        //Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KFC","Shogun","Burger King"]
        //Output: ["Shogun"]
        //Explanation: The only restaurant that appears in both lists is "Shogun".
        result = FindRestaurant(
            new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
            new string[] { "KFC", "Shogun", "Burger King" });
        Console.WriteLine(string.Join(", ", result));

        //Input: list1 = ["happy", "sad", "good"], list2 = ["sad", "happy", "good"]
        //Output: ["sad", "happy"]
        result = FindRestaurant(
            new string[] { "happy", "sad", "good" },
            new string[] { "sad", "happy", "good" });
        Console.WriteLine(string.Join(", ", result));
    }
}