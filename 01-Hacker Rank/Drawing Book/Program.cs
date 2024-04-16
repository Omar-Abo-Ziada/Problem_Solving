namespace Drawing_Book
{
    internal class Program
    {
        public static int pageCount(int n, int p)
        {
            int From_Start = 0, From_End = 0, Less_Moves = 0;
            if (p == 1 || p == n)
            {
                Less_Moves = 0;
                return Less_Moves;
            }
            else if (p % 2 == 0)
            {
                From_Start = p / 2;
            }
            else if ((p - 1) % 2 == 0)
            {
                From_Start = (p - 1) / 2;
            }
            if (n % 2 == 0)
            {
                From_End = (n / 2) - From_Start;
            }
            else if ((n - 1) % 2 == 0)
            {
                From_End = ((n - 1) / 2) - From_Start;
            }
            if (From_Start > From_End)
                return Less_Moves = From_End;
            else if (From_Start < From_End)
                return Less_Moves = From_Start;
            else
                return Less_Moves = From_Start = From_End;
        }
    static void Main(string[] args)
        {

        }
    }
}
