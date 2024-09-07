namespace G._Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            char[] charArr = S.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == ',')
                {
                    charArr[i] = ' ';
                }
                else
                {
                    if (Char.IsUpper(charArr[i]))
                    {
                        charArr[i] = Char.ToLower(charArr[i]);
                    }
                    else
                    {
                        charArr[i] = Char.ToUpper(charArr[i]);
                    }
                }
                
            }

            Console.WriteLine(new string(charArr));
        }
    }
}