using System;

namespace Fizz_Buzz
{
    internal class Program
    {
       //static public IList<string> FizzBuzz(int n)
       // {
       //     IList<string> result = new List<string>();

       //     for (int i = 1 ; i <= n; i++)
       //     {
       //         if((i % 3 == 0) && (i % 5 == 0))
       //             result.Add("FizzBuzz");

       //         else if (i % 3 == 0 )
       //             result.Add("Fizz");

       //         else if (i % 5 == 0)
       //             result.Add("Buzz");

       //         else
       //             result.Add(i.ToString());
       //     } 
       //     return result;
       // }
       static public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region documentaion
            //Given an integer n, return a string array answer(1 - indexed) where:

            //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
            //answer[i] == "Fizz" if i is divisible by 3.
            //answer[i] == "Buzz" if i is divisible by 5.
            //answer[i] == i(as a string) if none of the above conditions are true.


            //Example 1:

            //Input: n = 3
            //Output: ["1","2","Fizz"]
            //Example 2:

            //Input: n = 5
            //Output: ["1","2","Fizz","4","Buzz"]
            //Example 3:

            //Input: n = 15
            //Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]


            //Constraints:

            //1 <= n <= 104 
            #endregion

            Console.WriteLine(FizzBuzz(15));   
        }
    }
}
