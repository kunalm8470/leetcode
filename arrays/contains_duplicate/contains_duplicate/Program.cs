using System;
using System.Collections.Generic;
using System.Linq;

namespace contains_duplicate
{
    class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return false;
            }

            Dictionary<int, int> frequencyLookup = new Dictionary<int, int>();
            foreach (int item in nums)
            {
                if (!frequencyLookup.ContainsKey(item))
                {
                    frequencyLookup[item] = 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            bool res1 = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            bool res2 = ContainsDuplicate(new int[] { 1, 2, 3, 4 });
            bool res3 = ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        }
    }
}
