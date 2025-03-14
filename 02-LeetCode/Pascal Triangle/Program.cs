namespace Pascal_Triangle;

internal class Program
{
    static void Main(string[] args)
    {
        IList<IList<int>> triangle = Generate(5);

        foreach (var item in triangle)
        {
            foreach (var i in item)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    //public static IList<IList<int>> Generate(int numRows)
    //{
    //    IList<IList<int>> triangle = new List<IList<int>>();

    //    for (int i = 0; i < numRows; i++)
    //    {
    //        List<int> row = new List<int>(new int[i + 1]);

    //        // Add at first and last index
    //        row[0] = 1;
    //        row[row.Count - 1] = 1;

    //        // If row has more than 2 elements => Add Sum of the previous row's elements (before and next to current index)
    //        if (row.Count > 2)
    //        {
    //            for (int j = 1; j < row.Count - 1; j++)
    //            {
    //                row[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
    //            }
    //        }
    //        triangle.Add(row);
    //    }
    //    return triangle;
    //}

    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            // Or I can use init all with ones and os does not need to add 1 at first and last index
            List<int> row = new(Enumerable.Repeat(1, i+1));

            // If row has more than 2 elements => Add Sum of the previous row's elements (before and next to current index)
            if (row.Count > 2)
            {
                for (int j = 1; j < row.Count - 1; j++)
                {
                    row[j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            triangle.Add(row);
        }
        return triangle;
    }
}