namespace Group_Anagrams;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         Input: strs = ["eat","tea","tan","ate","nat","bat"]
         Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        */

        string[] strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        IList<IList<string>> result = GroupAnagrams(strs);
        foreach (IList<string> group in result)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }
    }
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> hashMap = [];

        foreach (string word in strs)
        {
            // Convert to char array
            char[] chars = word.ToCharArray();

            // Sort characters
            Array.Sort(chars);

            // Create key
            string key = new(chars);

            // If key doesn't exist, create new list
            if (!hashMap.ContainsKey(key))
            {
                hashMap[key] = [];
            }

            // Add original word
            hashMap[key].Add(word);
        }

        return hashMap.Values
                      .Select(list => (IList<string>)list)
                      .ToList();
    }

}
