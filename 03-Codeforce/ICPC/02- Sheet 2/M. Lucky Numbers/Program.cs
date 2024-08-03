namespace M._Lucky_Numbers
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            #region doc
            //            time limit per test1 second
            //memory limit per test256 megabytes
            //Given two numbers A
            // and B
            //. Print all lucky numbers between A
            // and B
            // inclusive.
            //            Note:

            //The Lucky number is any positive number that its decimal representation contains only 4 and 7.

            //For example: numbers 4, 7, 47 and 744 are lucky and numbers 5, 17 and 174 are not.

            //Input
            //            Only one line containing two numbers A
            // and B
            //            (1≤A≤B≤105)
            //.

            //Output
            //Print all lucky numbers between A
            // and B
            // inclusive separated by a space. If there is no lucky number print -1.

            //Examples
            //InputCopy
            //4 20
            //OutputCopy
            //4 7
            //InputCopy
            //8 15
            //OutputCopy
            //- 1 
            #endregion

            string[] inputs;
            int first;
            int last;

            do
            {
                //Console.WriteLine("Enter first number then space then second number:");
                //Console.WriteLine("Note: Number Max digits is 5");

                inputs = Console.ReadLine().Split();

                if (inputs.Length < 2)
                {
                    Console.WriteLine("Please enter two numbers separated by a space.");
                    continue;
                }

            } while (!int.TryParse(inputs[0], out first) ||
                    !int.TryParse(inputs[1], out last) ||
                    first > last ||
                    first < 1 ||
                    last > 100_000);

            bool foundLuckyNumber = false;

            for (int i = first; i <= last; i++)
            {
                if (IsLuckyNumber(i))
                {
                    Console.Write($"{i} ");

                    foundLuckyNumber = true;
                }
            }

            if (!foundLuckyNumber)
            {
                Console.WriteLine("-1");
            }
        }

        internal static bool IsLuckyNumber(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;

                if (digit != 4 && digit != 7)
                {
                    return false;
                }

                num /= 10;  
            }

            return true;
        }
    }

}