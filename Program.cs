using System;

namespace cipher
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if(!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string doEncrypt(string input, int key)
        {
            string output = string.Empty;

            foreach(char ch in input)
            {
                output += cipher(ch, key);
            }

            return output;
        }

        public static string doDecrypt(string input, int key)
        {
            return doEncrypt(input, 26 - key);
        }


        static void Main(string[] args)
        {
            Console.Write("string: ");
            string inputString = Console.ReadLine();
            int key = 1;
            for (int i = 0; i <= 26; ++i)
            {
                // string cipherText = doEncrypt(inputString, key);
                // Console.WriteLine(cipherText);
                string text = doDecrypt(inputString, key);
                Console.WriteLine($"{text} Key: {key}");
                ++key;
            }
        }
    }
}
