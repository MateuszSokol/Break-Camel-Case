using System;
using System.Text;

namespace Break_Camel_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            String word = "AAlaMaKota";

            camelCase(ref word);


            Console.WriteLine(word);


        }
        public static ref string camelCase(ref String word)
        {
            char[] wordAlphabet = word.ToCharArray();

            StringBuilder buildWordWithSpaces = new StringBuilder();


            for (int i = 0; i < wordAlphabet.Length; i++)
            {
                String b = wordAlphabet[i].ToString().ToUpper();
                String c = wordAlphabet[i].ToString();
                if (c.Equals(b) && i != 0)
                {
                    buildWordWithSpaces.Append(" ");
                }
                buildWordWithSpaces.Append(wordAlphabet[i]);
            }

            word = buildWordWithSpaces.ToString();

            return ref word;
        }
    }
}
