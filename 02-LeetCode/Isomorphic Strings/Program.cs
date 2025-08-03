using System.Linq;

namespace Isomorphic_Strings;

internal class Program
{
    static public bool IsIsomorphic(string s, string t)
    {
        if (String.IsNullOrEmpty(s) ||
              String.IsNullOrEmpty(t) ||
             s.Length != t.Length) return false;

        Dictionary<char, char> mapST_HashMap = new();
        HashSet<char> mappedT_HashSet = new();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (mapST_HashMap.ContainsKey(c1))
            {
                if (mapST_HashMap[c1] != c2)
                    return false;
            }
            else
            {
                if (mappedT_HashSet.Contains(c2))
                    return false;

                mapST_HashMap.Add(c1, c2);
                mappedT_HashSet.Add(c2);
            }
        }

        return true;

    }


    static void Main(string[] args)
    {
        //Example 1:
        //Input: s = "egg", t = "add"
        //Output: true
        //Explanation: The characters 'e' and 'a' map to the same character, and the characters 'g' and 'd' map to the same character.
        Console.WriteLine(IsIsomorphic("egg", "add"));

        //Example 2:
        //Input: s = "foo", t = "bar"
        //Output: false
        //Explanation: The characters 'f' and 'b' map to different characters, and the characters 'o' and 'a' map to different characters.
        Console.WriteLine(IsIsomorphic("foo", "bar"));

        //Example 3:
        //Input: s = "paper", t = "title"
        //Output: true
        //Explanation: The characters 'p' and 't' map to the same character, and the characters 'a' and 'l' map to the same character.
        Console.WriteLine(IsIsomorphic("paper", "title"));

        //Example 4:
        //Input: s = "badc", t = "baba"
        //Output: false
        //Explanation: The characters 'b' and 'a' map to different characters, and the characters 'd' and 'c' map to the same character.
        Console.WriteLine(IsIsomorphic("badc", "baba"));

    }
}