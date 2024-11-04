namespace _383._Ransom_Note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("az", "ab"));
        }

        static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineHashset = new Dictionary<char, int>();
            var magzineCharArr = magazine.ToCharArray();
            int count;
            for (int i = 0; i < magazine.Length; i++)
            {
                count = 0;

                if (magazineHashset.ContainsKey(magzineCharArr[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < magazine.Length; j++)
                {

                    if (magzineCharArr[i] == magzineCharArr[j])
                    {
                        count++;
                    }
                }
                magazineHashset.Add(magzineCharArr[i], count);
            }

            //===============================================================

            Dictionary<char, int> ransomNoteHashset = new Dictionary<char, int>();
            var ransomeNoteCharArr = ransomNote.ToCharArray();
            int countNote;
            for (int i = 0; i < ransomNote.Length ; i++)
            {
                countNote = 0;

                if (ransomNoteHashset.ContainsKey(ransomeNoteCharArr[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < ransomNote.Length; j++)
                {

                    if (ransomeNoteCharArr[i] == ransomeNoteCharArr[j])
                    {
                        countNote++;
                    }
                }
                ransomNoteHashset.Add(ransomeNoteCharArr[i], countNote);
            }

            // ===================================================================

            bool isConstructed = false;

            foreach (KeyValuePair<char, int> pair in ransomNoteHashset)
            {
                if (magazineHashset.ContainsKey(pair.Key))
                {
                    if (magazineHashset[pair.Key] >= pair.Value)
                    {
                        isConstructed = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (isConstructed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}