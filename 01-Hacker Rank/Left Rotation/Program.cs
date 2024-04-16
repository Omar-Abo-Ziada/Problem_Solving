namespace Left_Rotation
{
    internal class Program
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int n = arr.Count;
            int[] rotated = new int[n];
            List<int> result = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                if ((i - d) < 0)
                {
                    rotated[n - d + i] = arr[i];
                }
                else
                {
                    rotated[i - d] = arr[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                result.Add(rotated[i]);
            }

            return result;
        }
    
    static void Main(string[] args)
        {
        }
    }
}
