namespace W._Encrypt___Decrypt_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doc
            //            W. Encrypt & Decrypt Message
            //time limit per test1 second
            //memory limit per test256 megabytes
            //Given a number Q
            // and a string S
            //. If Q
            // is equal to 1 then print S
            // after encrypting it otherwise, print S
            // after decrypting it.

            //Key = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/
            //            ".

            //Original = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".

            //Note:

            //In Encryption: For each letter x
            // in "Original" replace it by the equivalent letter y
            // from "Key"
            //In Decryption: For each letter y
            // in "Key" replace it by the equivalent letter x
            //            from "Original".
            //Key and Original have the same length.
            //Input
            //The first line contains a number Q
            // (1≤Q≤2)
            //.

            //The second line contains a string S
            // (1≤| S |≤105)
            // where | S | is the length of the string and it consists of lowercase and uppercase English letters.

            //Output
            //Print the answer required above.

            //Examples
            //InputCopy
            //1
            //Egypt
            //OutputCopy
            //ZaoQR
            //InputCopy
            //2
            //#@_!=.+-*/
            //OutputCopy
            //0123456789
            //InputCopy
            //2
            //ZaoQR
            //OutputCopy
            //Egypt  
            #endregion

            string Key = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/";

            string Original = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            int option = int.Parse(Console.ReadLine());

            string word = Console.ReadLine();

            if(option == 1)
            {
                Encrypt(Key, Original, word);
            }
            else
            {
                Decrypt(Key, Original, word);
            }


        }

        private static void Encrypt(string Key , string Original , string word)
        {
            char[] wordArr = word.ToCharArray();
            char[] keyArr = Key.ToCharArray();

            char[] wordArrEncrypted = new char[wordArr.Length];

            int index ;

            for (int i = 0; i < wordArr.Length; i++)
            {
                index = Original.IndexOf(word[i]);

                wordArrEncrypted[i] = keyArr[index];
            }

            Console.WriteLine(new string(wordArrEncrypted));
        }

        private static void Decrypt(string Key, string Original, string word)
        {
            char[] wordArr = word.ToCharArray();
            char[] keyArr = Key.ToCharArray();

            char[] wordArrEncrypted = new char[wordArr.Length];

            int index;

            for (int i = 0; i < wordArr.Length; i++)
            {
                index = Key.IndexOf(word[i]);

                wordArrEncrypted[i] = Original[index];
            }

            Console.WriteLine(new string(wordArrEncrypted));
        }
    }
}