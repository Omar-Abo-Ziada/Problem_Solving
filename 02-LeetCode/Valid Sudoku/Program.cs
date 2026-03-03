namespace Valid_Sudoku;

internal class Program
{
    private static void Main(string[] args)
    {
        char[][] board = new char[][]
        {
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };

        //var board2 = 
        //    [
        //    [".", ".", ".",   ".", "5", ".",   ".", "1", "."],
        //    [".", "4", ".",   "3", ".", ".",   ".", ".", "."],
        //    [".", ".", ".",   ".", ".", "3",   ".", ".", "1"], 

        //    ["8", ".", ".",   ".", ".", ".",   ".", "2", "."], 
        //    [".", ".", "2",   ".", "7", ".",   ".", ".", "."],
        //    [".", "1", "5",   ".", ".", ".",   ".", ".", "."],

        //    [".", ".", ".",   ".", ".", "2",   ".", ".", "."], 
        //    [".", "2", ".",   "9", ".", ".",   ".", ".", "."], 
        //    [".", ".", "4",   ".", ".", ".",   ".", ".", "."]
        //    ];
        bool result = IsValidSudoku(board);
        Console.WriteLine(result);
    }
    public static bool IsValidSudoku(char[][] board)
    {
        // rows check
        for (int i = 0; i < board.Length; i++)
        {
            char[]? currentRow = board[i];
            HashSet<char>? rowSet = [];

            for (int j = 0; j < currentRow.Length; j++)
            {
                char currentValue = currentRow[j];

                if (currentValue is not '.')
                {
                    if (rowSet.Contains(currentValue))
                        return false;
                    else
                        _ = rowSet.Add(currentValue);
                }
            }
        }

        // columns check
        for (int i = 0; i < board[0].Length; i++)
        {
            HashSet<char> columnsSet = [];
            for (int j = 0; j < board.Length; j++)
            {
                char currentValue = board[j][i];
                if (currentValue is not '.')
                {
                    if (columnsSet.Contains(currentValue))
                        return false;
                    else
                        _ = columnsSet.Add(currentValue);
                }
            }
        }

        // sub-boxes check
        for (int boxRow = 0; boxRow < 9; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < 9; boxCol += 3)
            {
                HashSet<char> boxSet = [];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char currentValue = board[boxRow + i][boxCol + j];

                        if (currentValue is not '.')
                        {
                            if (boxSet.Contains(currentValue))
                                return false;

                            _ = boxSet.Add(currentValue);
                        }
                    }
                }
            }
        }

        return true;
    }
}
