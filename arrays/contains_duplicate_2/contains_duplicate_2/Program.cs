using System;
using System.Collections.Generic;

namespace contains_duplicate_2
{
    class Program
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return false;
            }

            Dictionary<int, int> indexLookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
               
                if (indexLookup.ContainsKey(num) && i - indexLookup[num] <= k)
                {
                    return true;
                }
                else
                {
                    indexLookup[nums[i]] = i;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            bool res1 = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);
            bool res2 = ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            bool res3 = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
        }
    }
}
