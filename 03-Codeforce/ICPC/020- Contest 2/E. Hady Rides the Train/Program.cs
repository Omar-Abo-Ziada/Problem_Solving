namespace E._Hady_Rides_the_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*E. Hady Rides the Train
  time limit per test0.5 seconds
  memory limit per test256 megabytes
  Hady wants to ride a train. He knows his seat number, but he doesn't know the corresponding row or column number of his seat. However, he knows that each row consists of exactly 4
   seats. The train seats are numbered from zero as shown in the figure:


  Given the seat number, can you find the corresponding row and column numbers of the seat?

  Input
  Only one line containing id
   (0≤id≤1018
  ) – the seat number.

  Output
  The row and column numbers of the seat.

  Examples
  InputCopy
  5
  OutputCopy
  1 2
  InputCopy
  2
  OutputCopy
  0 2
  InputCopy
  0
  OutputCopy
  0 0
  InputCopy
  13
  OutputCopy
  3 2
  */ 
            #endregion

            long seatID = long.Parse(Console.ReadLine());

            long rowIndex = (seatID / 4);

            bool isReversed = rowIndex % 2 != 0;

            long colIndex;

            if (isReversed)
            {
                colIndex = 3 - (seatID % 4) ;
            }
            else
            {
                colIndex = seatID % 4;
            }

            Console.WriteLine($"{rowIndex} {colIndex}");


        }
    }
}