using System;
using System.Collections.Generic;

namespace partition_labels
{
    class Program
    {
        public static IList<int> PartitionLabels(string S)
        {
            int[] lastIndexArr = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                lastIndexArr[S[i] - 'a'] = i;
            }

            IList<int> result = new List<int>();
            int start = 0;
            int end = 0;
            for (int i = 0; i < S.Length; i++)
            {
                end = Math.Max(end, lastIndexArr[S[i] - 'a']);
                if (i == end)
                {
                    result.Add(end - start + 1);
                    start = end + 1;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            IList<int> res1 = PartitionLabels("ababcbacadefegdehijhklij");
        }
    }
}
