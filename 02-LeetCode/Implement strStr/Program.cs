namespace Implement_strStr;

internal class Program
{
    static void Main(string[] args)
    {
        string haystack1 = "hello";
        string needle1 = "ll";
        int result1 = StrStr(haystack1, needle1);
        Console.WriteLine(result1); // 2

        string haystack2 = "sadbutsad";
        string needle2 = "sad";
        int result2 = StrStr(haystack2, needle2);
        Console.WriteLine(result2); // 0

        string haystack3 = "leetcode";
        string needle3 = "leeto";
        int result3 = StrStr(haystack3, needle3);
        Console.WriteLine(result3); // -1

        string haystack4 = "aaa";
        string needle4 = "aaaa";
        int result4 = StrStr(haystack4, needle4);
        Console.WriteLine(result4); // -1

        string haystack5 = "mississippi";
        string needle5 = "issip";
        int result5 = StrStr(haystack5, needle5);
        Console.WriteLine(result5); // 4

        string haystack6 = "mississippi";
        string needle6 = "issipi";
        int result6 = StrStr(haystack6, needle6);
        Console.WriteLine(result6); // -1

        string haystack7 = "abc";
        string needle7 = "c";
        int result7 = StrStr(haystack7, needle7);
        Console.WriteLine(result7); // 2
    }

    public static int StrStr(string haystack, string needle)
    {
        char[] haystackArray = haystack.ToCharArray();
        char[] needleArray = needle.ToCharArray();

        if (haystack is null || haystack == string.Empty ||
            needle is null || needle == string.Empty ||
            haystack.Length < needle.Length)
            return -1;

        for (int i = 0; i < haystackArray.Length; i++)
        {
            bool isFound = false;
            int startIndex = i;

            if (haystackArray[i] == needleArray[0])
            {
                startIndex = i;
                int outerIndex = i;

                for (int j = 0; j < needleArray.Length; j++)
                {
                    if (haystackArray[outerIndex] != needleArray[j])
                    {
                        isFound = false;
                        break;
                    }

                    if (!isFound && j == needleArray.Length - 1)
                    {
                        isFound = true;
                        break;
                    }
                    else if (outerIndex == haystackArray.Length - 1)
                    {
                        isFound = false;
                        break;
                    }
                    else
                    {
                        outerIndex++;
                    }
                }

                if (isFound)
                {
                    return startIndex;
                }
            }
        }

        return -1;
    }
}