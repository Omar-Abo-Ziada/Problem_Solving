namespace Age_in_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // optimum sol : 

            int N = int.Parse(Console.ReadLine());

            int Years = N / 365;

            N = N % 365;

            int Months = N / 30;

            N = N % 30;

            int Days = N;


            Console.WriteLine($"{Years} years");
            Console.WriteLine($"{Months} months");
            Console.WriteLine($"{Days} days");

            #region bad sol

            //int N = int.Parse(Console.ReadLine());

            //int Years = N / 365;

            //decimal YearsFraction = ((decimal)N / 365) - Years;

            //decimal MonthsFraction = (YearsFraction * 365) / 30;

            //int Months = (int)MonthsFraction;

            //decimal DaysFraction = MonthsFraction - Months;

            //int Days = (int)(DaysFraction * 30);

            //Console.WriteLine($"{Years} years");
            //Console.WriteLine($"{Months} months");
            //Console.WriteLine($"{Days} days"); 
            #endregion


        }
    }
}
