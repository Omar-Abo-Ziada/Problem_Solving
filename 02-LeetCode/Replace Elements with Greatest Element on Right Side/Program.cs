namespace Replace_Elements_with_Greatest_Element_on_Right_Side
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [17, 18, 5, 4, 6, 1];

            arr = ReplaceElements(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 0 || arr is null) return [-1];

            int[] result = new int[arr.Length];

            int maxNumber = -1;

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > maxNumber)
                    {
                        maxNumber = arr[j];
                    }
                }

                result[i] = maxNumber;
            }

            result[arr.Length - 1] = -1;

            return result;
        }
    }
}