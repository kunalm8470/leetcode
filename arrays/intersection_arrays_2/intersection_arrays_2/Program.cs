using System;
using System.Collections.Generic;

namespace intersection_arrays_2
{
    class Program
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var n in nums1)
            {
                if (!map.ContainsKey(n)) map.Add(n, 0);
                map[n]++;
            }

            var res = new List<int>();
            foreach (var n in nums2)
            {
                if (map.ContainsKey(n) && map[n] > 0)
                {
                    res.Add(n);
                    map[n]--;
                }
            }

            return res.ToArray();
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 }, nums2 = { 9, 4, 9, 8, 4 };
            int[] res = Intersect(nums1, nums2);
        }
    }
}
