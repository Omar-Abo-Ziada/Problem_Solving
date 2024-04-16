using System.Runtime.CompilerServices;
using System.Xml;

namespace Min_and_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region original proplem sol
            string[] inputs = Console.ReadLine().Split();

            if (long.TryParse(inputs[0], out long A) &&
                long.TryParse(inputs[1], out long B) &&
                long.TryParse(inputs[2], out long C))
            {
                long max = Math.Max(C, (Math.Max(A, B)));
                long min = Math.Min(C, (Math.Min(A, B)));

                Console.WriteLine($"{min} {max}");
            }
            #endregion

            #region another sol
            //========================================
            //    string[] inputs = Console.ReadLine().Split();

            //    if (long.TryParse(inputs[0], out long A) &&
            //        long.TryParse(inputs[1], out long B) &&
            //        long.TryParse(inputs[2], out long C))
            //    {
            //        if (A > B && A > C)
            //        {
            //            if (B > C)
            //            {
            //                Console.WriteLine($"{C} {A}");
            //            }
            //            else if (C > B)
            //            {
            //                Console.WriteLine($"{B} {A}");
            //            }
            //        }
            //        else if (B > A && B > C)
            //        {
            //            if (A > C)
            //            {
            //                Console.WriteLine($"{C} {B}");
            //            }
            //            else if (C > A)
            //            {
            //                Console.WriteLine($"{A} {B}");
            //            }
            //        }
            //        else if (C > A && C > B)
            //        {
            //            if (A > B)
            //            {
            //                Console.WriteLine($"{B} {C}");
            //            }
            //            else if (B > A)
            //            {
            //                Console.WriteLine($"{A} {C}");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{A} {B} {C}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error : more than 3 numbers ! ");
            //    } 
            #endregion
        }
    }
}
