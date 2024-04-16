using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Reflection;
using System;
using System.ComponentModel.Design.Serialization;

namespace Data_Type_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            H.Data Type Guessing
            //time limit per test1 second
            //memory limit per test256 megabytes
            //inputstandard input
            //outputstandard output
            //Given three numbers n
            //, k
            // and a
            //.Identify whether the data type of n×ka
            // is int, long long or double.

            //Input
            //Only one line containing three numbers n
            //, k
            // and a
            // (1≤a,k,n≤2147483647
            //).

            //Output
            //Print "int", "long long" or "double"(without quotes) as described in the statement.

            //Examples
            //inputCopy
            //3 6 9
            //outputCopy
            //int
            //inputCopy
            //100000 200000 4
            //outputCopy
            //long long
            //Note
            //double is when a number has a floating-point.

            //int Range: [−2147483648,
            //    2147483647
            //].

            //long long can hold values of a bigger range than that of int. 
            #endregion

            string[] inputs = Console.ReadLine().Split();

            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);
            int a = int.Parse(inputs[2]);

            decimal d = ((decimal)n * k) / a;
            long l = ((long)n * k) / a;

            //Console.WriteLine($"int result : {(n * k) / a}");
            //Console.WriteLine($"double result : {d}");
            //Console.WriteLine($"long result : {l}");
            //Console.WriteLine(5000000000 > int.MaxValue);
            //Console.WriteLine((int)d);
            //Console.WriteLine((int)d);
            //Console.WriteLine((int)l);

            //  2147483647 249010911 249010911 ==> right : int

            //  100000 200000 4 ==> right : long long
            //  86294906 292379617 104468026  ==> right : double

            // 1745630534 1049007403 341361164  ==> right : double

            //Console.WriteLine(d);
            if (d > int.MaxValue )
            {
                Console.WriteLine("long long");
            }
            else 
            {
                int x = (int)d;

                if(x == d)
                {
                    Console.WriteLine("int");
                }
                else
                {
                    Console.WriteLine("double");
                }
            }
           

            #region trials
            //============================================
            //Console.WriteLine(long.MaxValue); //9223372036854775807
            //Console.WriteLine(double.MaxValue); //1.7976931348623157E+308
            //Console.WriteLine(int.MaxValue); //2147483647
            //2147483647

            //double x = 9223372036854775807;
            //long y = 9223372036854775807;

            //double a = 5.5;
            //long b = (long)a;

            //Console.WriteLine(b);

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //double x = long.MaxValue - 10;

            //int i = (int)x;

            //if(i == x)
            //    Console.WriteLine("int");
            //else
            //{
            //    Console.WriteLine("not int");

            //    long l = (long)x ;

            //    if(l == x)
            //        Console.WriteLine("long");
            //    else
            //        Console.WriteLine("double");
            //}

            //string[] inputs = Console.ReadLine().Split();

            //string n_Type = "" ;
            //string k_Type = "" ;
            //string a_Type = "" ;

            //double n = double.Parse(inputs[0]);
            //double k = double.Parse(inputs[1]);
            //double a = double.Parse(inputs[1]);

            //int x = (int)n;
            //if (n - x != 0)
            //{
            //    n_Type = "double";
            //}
            //else if (n - x == 0)
            //{
            //    n_Type = "int";
            //}


            //========================================

            //if (int.TryParse(inputs[0], out int n_Int))
            //{
            //    n_Type = "int";
            //}
            //else if (long.TryParse(inputs[0], out long n_Long))
            //{
            //    n_Type = "long";
            //}
            //else if (double.TryParse(inputs[0], out double n_Double))
            //{
            //    n_Type = "double";
            //}
            //else
            //{
            //    n_Type = "unknown";
            //}


            //if (int.TryParse(inputs[1], out int k_Int))
            //{
            //    k_Type = "int";
            //}
            //else if (double.TryParse(inputs[1], out double k_Double))
            //{
            //    k_Type = "double";
            //}
            //else if (long.TryParse(inputs[1], out long k_Long))
            //{
            //    k_Type = "long";
            //}
            //else
            //{
            //    k_Type = "unknown";
            //}


            //if (int.TryParse(inputs[2], out int a_Int))
            //{
            //    a_Type = "int";
            //}
            //else if (double.TryParse(inputs[2], out double a_Double))
            //{
            //    a_Type = "double";
            //}
            //else if (long.TryParse(inputs[2], out long a_Long))
            //{
            //    a_Type = "long";
            //}
            //else
            //{
            //    a_Type = "unknown";
            //}

            //Console.WriteLine($"n : {n_Type} \t k : {k_Type}\t a : {a_Type} "); 
            #endregion
        }
    }
}
