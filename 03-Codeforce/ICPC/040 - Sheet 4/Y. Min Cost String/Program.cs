using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine(); // Read the string with '?' characters.
        int[] cost = new int[26];

        // Read the costs as a single line and split by whitespace
        string[] costInputs = Console.ReadLine().Split();

        // Parse each cost value into the cost array
        for (int i = 0; i < 26; i++)
        {
            cost[i] = int.Parse(costInputs[i]);
        }

        int questionCounter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            questionCounter = 0;
            if (str[i] == '?')
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (str[j] == '?')
                    {
                        questionCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                // str =  ???????
                if (questionCounter == str.Length)
                {
                    Console.WriteLine(0);
                    Console.WriteLine(new string('a', str.Length));
                    // end program
                    return;
                }
                else
                {
                    // str = ???abcd
                    if (i == 0)
                    {
                        int minCost = int.MaxValue, index = 0;

                        // find first min cost char
                        for (int z = 0; z <= (str[questionCounter] - 'a'); z++)
                        {
                            int currentCost = Math.Abs(cost[str[questionCounter] - 'a'] - cost[z]);
                            if (minCost > currentCost)
                            {
                                minCost = currentCost;
                                index = z;
                            }
                        }

                        // replace the question marks with min char
                        char replacementChar = (char)(index + 'a');
                        for (int j = 0; j < questionCounter; j++)
                        {
                            str = str.Remove(i + j, 1).Insert(i + j, replacementChar.ToString());
                        }

                        i += questionCounter - 1;
                    }
                    // str = abcd???
                    else if (i + questionCounter == str.Length)
                    {
                        int minCost = int.MaxValue, index = 0;

                        // find first min cost char
                        for (int z = 0; z <= (str[i - 1] - 'a'); z++)
                        {
                            int currentCost = Math.Abs(cost[str[i - 1] - 'a'] - cost[z]);
                            if (minCost > currentCost)
                            {
                                minCost = currentCost;
                                index = z;
                            }
                        }

                        // replace the question marks with min char
                        char replacementChar = (char)(index + 'a');

                        for (int j = i; j < questionCounter + i; j++)
                        {
                            str = str.Remove(j, 1).Insert(j, replacementChar.ToString());
                        }

                        break;
                    }
                    // str = adb??sks
                    else
                    {
                        int minCost = int.MaxValue, index = 0;
                        // loop to find min cost in whole alphabet
                        for (int x = 0; x < 26; x++)
                        {
                            int currentCost = Math.Abs(cost[str[i - 1] - 'a'] - cost[x]) + Math.Abs(cost[x] - cost[str[i + questionCounter] - 'a']);
                            if (minCost > currentCost)
                            {
                                minCost = currentCost;
                                index = x;
                            }
                        }

                        // replace the question marks with min char
                        char replacementChar = (char)(index + 'a');

                        for (int j = i; j < i + questionCounter; j++)
                        {
                            str = str.Remove(j, 1).Insert(j, replacementChar.ToString());
                        }

                        i += questionCounter - 1;
                    }
                }
            }
        }

        long finalCost = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            finalCost += Math.Abs(cost[str[i] - 'a'] - cost[str[i + 1] - 'a']);
        }

        Console.WriteLine(finalCost);
        Console.WriteLine(str);
    }
}
