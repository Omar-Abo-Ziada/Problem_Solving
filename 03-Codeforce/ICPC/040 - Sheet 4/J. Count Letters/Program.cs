namespace J._Count_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            Dictionary<char,int> freqDic = new Dictionary<char,int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (freqDic.ContainsKey(S[i]))
                {
                    freqDic[S[i]]++;
                }
                else
                {
                    freqDic.Add(S[i], 1);
                }
            }

            var sortedKeys = freqDic.Keys.OrderBy(c => c);

            foreach (char key in sortedKeys)
            {
                Console.WriteLine($"{key} : {freqDic[key]}");
            }
        }
    }
}