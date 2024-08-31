namespace X._8_Neighbors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*X. 8 Neighbors
    time limit per test1 second
    memory limit per test256 megabytes
    Given two numbers N
     and M
    , a 2D array A
     of size N
     * M
     which contains 'x' or '.' only and two numbers X
    , Y
     which donates a cell position in A
     such that X
     is the row number and Y
     is the column number.
 
    Determine whether all neighbors of the given cell are 'x' or not.
 
    Note: The neighbor cell is any cell that shares an edge or a corner and it should be inside 2D array.
 
 
    Input
    First line contains two numbers N
    , M
     (2≤N,M≤100)
     N
     donates number of rows and M
     donates number of columns.
 
    Each of the next N
     lines will contain M
     symbol can be ('.' or 'x').
 
    Last line contains two numbers X
    , Y
     (1≤X≤N,1≤Y≤M)
    .
 
    Output
    Print "yes" if all neighbors of the given cell are 'x' otherwise, print "no" without quotations.
 
    Examples
    InputCopy
    3 3
    xxx
    x.x
    xxx
    2 2
    OutputCopy
    yes
    InputCopy
    3 3
    xxx
    xxx
    xx.
    2 2
    OutputCopy
    no
    InputCopy
    3 3
    xxx
    xxx
    xxx
    1 1
    OutputCopy
    yes*/
            #endregion

            string[] sizes = Console.ReadLine().Split();

            int N = int.Parse(sizes[0]);
            int M = int.Parse(sizes[1]);

            char[,] symbols = new char[N, M];

            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < symbols.GetLength(1); j++)
                {
                    symbols[i, j] = row[j];
                }
            }

            string[] point = Console.ReadLine().Split();

            int X = int.Parse(point[0]) - 1;
            int Y = int.Parse(point[1]) - 1;

            if (AreAllNeighborsX(symbols, X, Y))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static bool AreAllNeighborsX(char[,] symbols, int x, int y)
        {
            if (x > 0 && symbols[x - 1, y] != 'x')
                return false;

            if (x < symbols.GetLength(0) - 1 && symbols[x + 1, y] != 'x')
                return false;

            if (y > 0 && symbols[x, y - 1] != 'x')
                return false;

            if (y < symbols.GetLength(1) - 1 && symbols[x, y + 1] != 'x')
                return false;

            if (x > 0 && y > 0 && symbols[x - 1, y - 1] != 'x')
                return false;

            if (x > 0 && y < symbols.GetLength(1) - 1 && symbols[x - 1, y + 1] != 'x')
                return false;

            if (x < symbols.GetLength(0) - 1 && y > 0 && symbols[x + 1, y - 1] != 'x')
                return false;

            if (x < symbols.GetLength(0) - 1 && y < symbols.GetLength(1) - 1 && symbols[x + 1, y + 1] != 'x')
                return false;

            return true;
        }
    }
}
