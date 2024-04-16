using System.Diagnostics;

namespace the_occurrence_of_1_from_1_to_99_999_999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) and total up how many 1s were there.

            (Convert Numbers to String in Case one and use String Functions to Count 1s, 
            Use Only Mathematical Functions and Numeric values in case 2 and see the difference in performance) 
            Is There Any Other Way to Do it in Approximately 1 Second or less

             */
            //console.writeline(math.pow(10, 8) - 1);
            //console.writeline(99_999_999);

            //stopwatch sw = new stopwatch();
            //sw.start();
            //double num = math.pow(10, 8);  //better to use double because it't the return type of math.pow ....or we can use casting
            //int occurences = 0;
            //for (double i = 0; i < num; i++)
            //{
            //    string strnum = i.tostring();
            //    for (int j = 0; j < strnum.length; j++)
            //    {
            //        if (strnum[j] == '1')
            //            occurences++;
            //    }
            //}
            //sw.stop();
            //console.writeline(sw);
            //console.writeline(occurences);
            // it took 12.56 sec
            // the occurences is 80,000,000 ==> correct

            //===================================

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int num = 100_000_000 ; // that's a way 
            //  int n  = (int)Math.Pow(10, 8); // or this way 
            int occurences = 0;
            for (int i = 0; i <= num; i++)
            {
                int temp = i ;
                while (temp != 0 && temp != 1)
                {
                    //temp = i;

                    int units = temp % 10;
                    if (units == 1 )
                        occurences++;

                    temp = temp / 10;

                    if (temp == 1)
                        occurences++;
                }
            }  
            sw.Stop();
            Console.WriteLine(sw);
            Console.WriteLine(occurences );
            // it took 5.6 sec
            // the occurences is 80,000,000 ==> correct

            // then we concluse that the mathmatical way is much better than string way
            // it's nearly twice better 





        }
    }
}
