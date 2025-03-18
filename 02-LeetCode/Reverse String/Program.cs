namespace Reverse_String;

public class Program
{
    static void Main(string[] args)
    {
        char[] case1 = "hello".ToCharArray();
        ReverseString(case1);
        Console.WriteLine(case1); // Output: "olleh"
    }

    static public void ReverseString(char[] s)
    {
        if (s is null || !s.Any()) return;

        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
}