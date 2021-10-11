using System;
using System.Text;

namespace SquareOfPolybium
{
    class Program
    {

        static void Main(string[] args)
        {
             char[][] alphabet = new char[][]
            {
               new char[] {'a','b','c','d','e','f'},
               new char[] { 'g','h','l','j','k','l' },
               new char[] { 'm','n','o','p','q','r' },
               new char[] { 's','t','u','v','w','x'},
               new char[] { 'y','z'},
        };

        string texrCrypt = CryptTxt(alphabet);
            Console.WriteLine(texrCrypt);

            string decryptText = DecryptText(alphabet);
            Console.WriteLine(decryptText);



        }

        private static string DecryptText(char[][] alphabet)
        {
            Console.WriteLine("Input Decrrypt Text Ro Encrypt:");
            var inputCrypttext = Console.ReadLine().Split(new string[] { "X", "-" }, StringSplitOptions.RemoveEmptyEntries);
            string decryptText = null;
            for (int letter = 0; letter < inputCrypttext.Length - 1; letter++)
            {

                var x = int.Parse(inputCrypttext[letter]);
                var y = int.Parse(inputCrypttext[letter + 1]);
                letter++;
                decryptText += alphabet[x][y];
            }

            return decryptText;
        }

        private static string RemoveTireOnFinalCryptText(string texrCrypt)
        {
            var txt = texrCrypt.ToCharArray();
            if (txt[txt.Length - 1] is '-')
            {
                txt[txt.Length - 1] = '\0';
            }
           return new string(txt);
        }

        private static string CryptTxt(char[][] alphabet)
        {
            Console.WriteLine("Input text:");
            var text = Console.ReadLine().ToLower().ToCharArray();
            string texrCrypt = null;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    for (int k = 0; k < alphabet[j].Length; k++)
                    {

                        if (text[i] == alphabet[j][k])
                        {
                            texrCrypt += $"{j}X{k}-";
                        }
                    }
                }
            }
            return RemoveTireOnFinalCryptText(texrCrypt);
            
        }
    }
}
