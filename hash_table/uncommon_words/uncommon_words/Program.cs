using System;
using System.Collections.Generic;
using System.Linq;

namespace uncommon_words
{
    class Program
    {
        public static string[] UncommonFromSentences(string A, string B)
        {
            Dictionary<string, int> lookup = new Dictionary<string, int>();

            int wordIndex = 0, spaceIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == ' ' || i == A.Length - 1)
                {
                    spaceIndex = i - wordIndex;
                    if (i == A.Length - 1)
                    {
                        spaceIndex = i - wordIndex + 1;
                    }
                    
                    string word = A.Substring(wordIndex, spaceIndex);
                    if (!lookup.ContainsKey(word))
                    {
                        lookup[word] = 1;
                    }
                    else
                    {
                        lookup[word] += 1;
                    }

                    wordIndex = i + 1;
                }
            }

            wordIndex = 0;
            spaceIndex = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == ' ' || i == B.Length - 1)
                {
                    spaceIndex = i - wordIndex;
                    if (i == B.Length - 1)
                    {
                        spaceIndex = i - wordIndex + 1;
                    }

                    string word = B.Substring(wordIndex, spaceIndex);
                    if (!lookup.ContainsKey(word))
                    {
                        lookup[word] = 1;
                    }
                    else
                    {
                        lookup[word] += 1;
                    }

                    wordIndex = i + 1;
                }
            }

            return lookup.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
        static void Main(string[] args)
        {
            string[] res1 = UncommonFromSentences("this apple is sweet", "this apple is sour");
            string[] res2 = UncommonFromSentences("apple apple", "banana");
        }
    }
}
