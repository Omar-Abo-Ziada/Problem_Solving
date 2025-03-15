using System.Text;

namespace Add_Binary;

internal class Program
{
    static void Main(string[] args)
    {
        string a = "11";
        string b = "1";

        string c = "1010";
        string d = "1011";

        //Console.WriteLine((int)'1' - (int)'0');
        //Console.WriteLine((int)'0' - (int)'0');
        //Console.WriteLine((int)'0');

        string result1 = addBinary(a, b);
        Console.WriteLine(result1); // "100"

        string result2 = addBinary(c, d);
        Console.WriteLine(result2); // "10101"
    }

    static string addBinary(string a, string b)
    {
        StringBuilder stringBuilder = new StringBuilder();

        char[] a_Chars = a.ToCharArray();
        char[] b_Chars = b.ToCharArray();

        int maxLength = Math.Max(a_Chars.Length, b_Chars.Length);
        int carry = 0;

        for (int i = 0; i < maxLength; i++)
        {
            var char_A = i < a_Chars.Length ? a_Chars[a_Chars.Length - 1 - i] : '0';
            var char_B = i < b_Chars.Length ? b_Chars[b_Chars.Length - 1 - i] : '0';

            var digit_A = char_A == '1' ? 1 : 0;
            var digit_B = char_B == '1' ? 1 : 0;

            int sum = digit_A + digit_B + carry;

            stringBuilder.Append(sum % 2 == 0 ? '0' : '1');

            carry = sum / 2;
        }


        if (carry != 0)
        {
            stringBuilder.Append(carry);
        }

        char[] result = stringBuilder.ToString().ToCharArray();
        Array.Reverse(result);

        return new string(result);
    }


    // Old stupid solution not working
    //static string addBinary(string a, string b)
    //{
    //    StringBuilder stringBuilder = new StringBuilder();

    //    char[] a_Chars = a.ToCharArray();
    //    char[] b_Chars = b.ToCharArray();

    //    int smallerLength = a_Chars.Length < b_Chars.Length ?
    //                        a_Chars.Length : b_Chars.Length;

    //    char a_Pointer = a_Chars[a_Chars.Length - 1];
    //    char b_Pointer = b_Chars[b_Chars.Length - 1];
    //    int carry = 0;

    //    for (int i = smallerLength - 1; i >= 0; i--)
    //    {
    //        if (a_Pointer == '1' && b_Pointer == '1')
    //        {
    //            stringBuilder.Append(0.ToString());
    //            carry = 1;

    //            a_Pointer = a_Chars[i - 1];
    //            b_Pointer = b_Chars[i - 1];
    //        }
    //        else if ((a_Pointer == '1' && b_Pointer == '0') ||
    //                 (a_Pointer == '0' && b_Pointer == '1'))
    //        {
    //            stringBuilder.Append(1);

    //            a_Pointer = a_Chars[i - 1];
    //            b_Pointer = b_Chars[i - 1];
    //        }
    //        else if (a_Pointer == '0' && b_Pointer == '0')
    //        {
    //            stringBuilder.Append(0.ToString());

    //            a_Pointer = a_Chars[i - 1];
    //            b_Pointer = b_Chars[i - 1];
    //        }
    //        else
    //        {

    //        }

    //        if (carry == 1)
    //        {
    //            if (a_Pointer == '1' || b_Pointer == '1')
    //            {
    //                stringBuilder.Append(0.ToString());
    //                carry = 1;

    //                a_Pointer = a_Chars[i - 1];
    //                b_Pointer = b_Chars[i - 1];
    //            }
    //            else if ((a_Pointer == '1' && b_Pointer == '0') ||
    //                     (a_Pointer == '0' && b_Pointer == '1'))
    //            {
    //                stringBuilder.Append(1);
    //                carry = 0;

    //                a_Pointer = a_Chars[i - 1];
    //                b_Pointer = b_Chars[i - 1];
    //            }
    //            else if (a_Pointer == '0' && b_Pointer == '0')
    //            {
    //                stringBuilder.Append(1.ToString());
    //                carry = 0;

    //                a_Pointer = a_Chars[i - 1];
    //                b_Pointer = b_Chars[i - 1];
    //            }
    //        }
    //    }

    //    return stringBuilder.ToString();
    //}
}