namespace U._Is_B_a_subsequence_of_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            /*U. Is B a subsequence of A ?
  time limit per test1 second
  memory limit per test256 megabytes
  a sub sequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.

  IF array = [1,6,3 , 7] then the some subsequences are [1,3,7] , [6,7] , [1] , [6,3,7] , [1,7] .

  Something like [3,1] and [6 , 7 , 1] would not be sub sequences of the array [1,6,3 , 7].

  Given 2 numbers N
  , M
   and 2 arrays A
   consists of N
   numbers and B
   consists of M
   numbers. Determine whether B
   is a sub-sequence of A
   or not.

  Note: The array B
   is called a sub-sequence of A
   if it's possible to remove zero or some elements from A
   to get B
  .

  For example: if A
  =[1,4,7], and B
   is [1], [1,4], [1,7],[1,4,7] or [4,7] then B
   is a sub-sequence of A
  .

  Input
  First line contains two numbers N,M
   (1≤N≤104,1≤M≤N)
   , the sizes of arrays A
   and B
   respectively.

  Second line contains N
   numbers (1≤Ai≤109)
   elements of array A
  .

  Third line contains M
   numbers (1≤Bi≤109)
   elements of array B
  .

  Output
  Print "YES" (without the quotes), if B
   is a sub-sequence of A
   otherwise, print "NO" (without the quotes).

  Examples
  InputCopy
  3 2
  1 4 7
  1 7
  OutputCopy
  YES
  InputCopy
  7 4
  1 8 4 7 5 2 7
  4 5 7 2
  OutputCopy
  NO
  InputCopy
  3 3
  21 8 40
  21 8 40
  OutputCopy
  YES
  */
            #endregion

            string[] sizes = Console.ReadLine().Split();

            int N = int.Parse(sizes[0]);
            int M = int.Parse(sizes[1]);

            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if(IsSubSequence(A, B))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool IsSubSequence(int[] A , int[] B)
        {
            if(B.Length == A.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] != B[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else if(B.Length > A.Length)
            {
                return false;
            }
            else
            {
                int prevIndex = -1;
                bool elementFound;

                for (int i = 0; i < B.Length; i++)
                {
                   elementFound = false;

                    for (int j = 0; j < A.Length; j++)
                    {
                        if (B[i] == A[j] && j > prevIndex)
                        {
                            prevIndex = j;
                            elementFound = true;
                            break;
                        }
                    }

                    if (!elementFound)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}