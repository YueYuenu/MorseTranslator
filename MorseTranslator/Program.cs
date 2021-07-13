using System;
using System.Collections.Generic;

namespace MorseTranslator
{
    public class Program
    {
        private static Dictionary<char, string> Morse;

        static void Main()
        {
            InitialiseDictionary();

            Console.WriteLine("Text to be translated here.");
            string input = Console.ReadLine();
            input = input.ToUpper();
            

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                    Console.Write('/');

                char c = input[i];
                if (Morse.ContainsKey(c))
                    Console.Write(Morse);
            }


            Console.WriteLine("Press ANY KEY to close this window.");
            Console.ReadLine();
        }

        private static void InitialiseDictionary()
        {
            Morse = new Dictionary<char, string>()
            {

                {' ', "/"},
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...-"},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'0', "-----"},
            };


        }

        


    }
}
