using System.ComponentModel;
using System.Linq;

namespace Pascal_s_Triangle_II;

internal class Program
{
    static void Main(string[] args)
    {
        var list1 = GetRow(3);
        foreach (var row in list1)
        {
            Console.Write(row + " ");
        }
        Console.WriteLine();
    }

    public static IList<int> GetRow(int rowIndex)
    {
        List<int> row = new List<int>(Enumerable.Repeat<int>(0, rowIndex + 1));
        row[0] = 1;

        for (int i = 1; i < row.Count; i++)
        {
            for (int j = i; j > 0; j--)
            {
                row[j] += row[j - 1];
            }
        }

        return row;
    }
}