using System;
using System.Collections.Generic;
using System.Text;

namespace unique_morse_code_strings
{
    class Program
    {
        public static int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> hs = new HashSet<string>();
            Dictionary<char, string> morseCodeLookup = new Dictionary<char, string>
            {
                ['a'] = ".-",
                ['b'] = "-...",
                ['c'] = "-.-.",
                ['d'] = "-..",
                ['e'] = ".",
                ['f'] = "..-.",
                ['g'] = "--.",
                ['h'] = "....",
                ['i'] = "..",
                ['j'] = ".---",
                ['k'] = "-.-",
                ['l'] = ".-..",
                ['m'] = "--",
                ['n'] = "-.",
                ['o'] = "---",
                ['p'] = ".--.",
                ['q'] = "--.-",
                ['r'] = ".-.",
                ['s'] = "...",
                ['t'] = "-",
                ['u'] = "..-",
                ['v'] = "...-",
                ['w'] = ".--",
                ['x'] = "-..-",
                ['y'] = "-.--",
                ['z'] = "--.."
            };

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    builder.Append(morseCodeLookup[currentWord[j]]);
                }
                hs.Add(builder.ToString());
                builder.Length = 0;
            }

            return hs.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
