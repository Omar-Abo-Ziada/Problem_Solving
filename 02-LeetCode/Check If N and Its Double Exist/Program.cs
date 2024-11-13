namespace Check_If_N_and_Its_Double_Exist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [-2, 0, 10, -19, 4, 6, -8];

            Console.WriteLine(CheckIfExist(arr));
        }

        static bool CheckIfExist(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();

            foreach (int num in arr)
            {
                if (hashSet.Contains(num * 2) || (num % 2 == 0 && hashSet.Contains(num / 2)))
                {
                    return true;
                }

                hashSet.Add(num);
            }

            return false;
        }

        //static bool CheckIfExist(int[] arr)
        //{
        //    Dictionary<int, int> hashTable = new Dictionary<int, int>();

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        hashTable.Add(i, arr[i]);
        //    }

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int currentValue = arr[i];

        //        if (hashTable.ContainsValue(currentValue * 2) && currentValue != 0)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}