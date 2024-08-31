namespace R._Permutation_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayLength = int.Parse(Console.ReadLine());

                int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (IsPermutaion(A, B))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static bool IsPermutaion(int[] A, int[] B)
        {
            // Importaaaaant : Sort both arrays first to check the existance and frequency
            Array.Sort(A);
            Array.Sort(B);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
