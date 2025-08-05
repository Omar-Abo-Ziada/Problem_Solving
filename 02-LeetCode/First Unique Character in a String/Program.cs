namespace First_Unique_Character_in_a_String;

internal class Program
{
    public int FirstUniqChar(string s)
    {
        if (String.IsNullOrEmpty(s)) return -1;

        Dictionary<char, int> charsMap = new(); // (key)char => (value)occurances count
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (charsMap.ContainsKey(c))
            {
                charsMap[c]++;
            }
            else
            {
                charsMap.Add(c, 1);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (charsMap[s[i]] == 1)
                return i;
        }

        return -1; // No unique character found
    }

    static void Main(string[] args)
    {
    }
}