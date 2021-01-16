using System;
using System.Collections.Generic;
using System.Linq;

namespace majority_element_in_array
{
    class Program
    {
        public static int MajorityElement(int[] nums)
        {
            
            int threshold = Convert.ToInt32(Math.Floor(Convert.ToDouble(nums.Length / 2)));
            Dictionary<int, int> frequencyLookup = new Dictionary<int, int>();

            foreach (int item in nums)
            {
                if (!frequencyLookup.ContainsKey(item))
                {
                    frequencyLookup[item] = 1;
                }
                else
                {
                    frequencyLookup[item] += 1;
                }
            }

            (int key, int value) = frequencyLookup.FirstOrDefault((kvp) => kvp.Value > threshold);
            return key;
        }

        static void Main(string[] args)
        {
            int res1 = MajorityElement(new int[] { 3, 2, 3 });
            int res2 = MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        }
    }
}
