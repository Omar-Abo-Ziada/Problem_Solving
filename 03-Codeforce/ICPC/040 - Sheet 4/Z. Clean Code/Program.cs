using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CleanCode
{
    static void Main()
    {
        var cleanedLines = new List<string>();
        string line;

        Console.WriteLine("Enter the C++ source code (end input with an empty line):");

        while ((line = Console.ReadLine()) != null)
        {
            if (line == string.Empty)
                break;

            string cleanedLine = Regex.Replace(line, @"//.*", "");

            cleanedLine = Regex.Replace(cleanedLine, @"/\*.*?\*/", "", RegexOptions.Singleline);

            cleanedLine = cleanedLine.Trim();

            if (!string.IsNullOrWhiteSpace(cleanedLine))
            {
                cleanedLines.Add(cleanedLine);
            }
        }

        foreach (string cleanedLine in cleanedLines)
        {
            Console.WriteLine(cleanedLine);
        }
    }
}
