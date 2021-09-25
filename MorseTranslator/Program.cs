using System;
using System.Collections.Generic;

namespace MorseTranslator
{
    public class Program
    {
        private static Dictionary<char, string> Morse;
        
        static void Main()
        {
            

            Console.WriteLine("Press 1 to translate text to morse.");
            Console.WriteLine("Press 2 to translate morse to text.");
            var translatorMode = Console.ReadLine();

            switch (translatorMode)
            {
                case "1":
                    TextToMorse();
                    break;

                case "2":
                    MorseToText();
                    break;

            }

            /* if (translatorMode == "1");
            //send to text to morse

            else if (translatorMode == "2");
            //send to morse to text 

            else Console.WriteLine("You must press 1 or 2."); */

        }

        static void TextToMorse()
        {
            //following code is text to morse

            InitialiseMorseDictionary();

            Console.WriteLine("Text to be translated here.");
            string input = Console.ReadLine();
            input = input.ToUpper();


            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write('/');
                }

                char c = input[i];
                if (Morse.ContainsKey(c))
                {
                    Console.Write(Morse[c]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press ESC to close this window.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }

        static void MorseToText()
        {
            //following code is morse to text

            InitialiseTextDictionary();

            Console.WriteLine("Text to be translated here. Please separate morse letters by /");
            string input = Console.ReadLine();
            

            //foreach (string i in input.Split(" "))
            {
                string[] splitSp = input.Split();

                for (int i = 0; i < splitSp.Length; i++)
                {
                    if (i != 0)
                    
                    
                    Console.Write(' ');

                    foreach (string j in splitSp[i].Split("/"))
                    {
                        if (MorseToTextD.ContainsKey(j))
                        {
                            Console.Write(MorseToTextD[j]);
                        }
                    }
                }

                
                 
            }

            Console.WriteLine();
            Console.WriteLine("Press ESC to close this window.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }

        
        private static void InitialiseMorseDictionary()
        {
            Morse = new Dictionary<char, string>()
            {

                {'.', ".-.-.-"},
                {',', "--..--"},
                {'?', "..--.."},
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

        private static Dictionary<string, char> MorseToTextD;
        private static void InitialiseTextDictionary()
        {

            MorseToTextD = new Dictionary<string, char>()
             {
                {".-.-.-", '.' },
                {"--..--", ',' },
                {"..--..", '?' },
                {".-", 'A'},
                {"-...", 'B' },
                {"-.-.", 'C' },
                {"-..", 'D' },
                {".", 'E' },
                {"..-.", 'F' },
                {"--.", 'G' },
                {"....", 'H' },
                {"..", 'I' },
                {".---", 'J' },
                {"-.-", 'K' },
                {".-..", 'L' },
                {"--", 'M' },
                {"-.", 'N' },
                {"---", 'O' },
                {".--.", 'P' },
                {"--.-", 'Q' },
                {".-.", 'R' },
                {"...", 'S' },
                {"-", 'T' },
                {"..-", 'U' },
                {"...-", 'V' },
                {".--", 'W' },
                {"-..-", 'X' },
                {"-.--", 'Y' },
                {"--..", 'Z' },
                {".----", '1' },
                {"..---", '2' },
                {"...--", '3' },
                {"....-", '4' },
                {".....", '5' },
                {"-....", '6' },
                {"--...", '7' },
                {"---..", '8' },
                {"----.", '9' },
                {"-----", '0' },
                };
        
            }
    }
}