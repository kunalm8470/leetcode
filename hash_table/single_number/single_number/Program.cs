using System;
using System.Collections.Generic;
using System.Linq;

namespace single_number
{
    class Program
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!lookup.ContainsKey(num))
                {
                    lookup.Add(num, 1);
                }
                else
                {
                    lookup[num] += 1;
                }
            }

            return lookup.FirstOrDefault(x => x.Value == 1).Key;
        }

        static void Main(string[] args)
        {
            int res1 = SingleNumber(new int[] { 2, 2, 1 });
            int res2 = SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            int res3 = SingleNumber(new int[] { 1 }); 
        }
    }
}
