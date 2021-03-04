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
            Console.Write("Brute Force to decrypt: ");
            string inputString = Console.ReadLine();
            for (int i = 1; i <= 26; ++i)
            {
                string text = doDecrypt(inputString, i);
                Console.WriteLine($"{text} Key: {i}");
            }

            Console.WriteLine("-------------------////////-----------------------");

            Console.Write($"Input Key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Do encrypt: ");
            string result = doEncrypt(inputString, key);
            Console.WriteLine($"Encrypt result: {result}");
        }
    }
}
