using System;
using System.Collections.Generic;
using System.Linq;

namespace intersection_arrays
{
    class Program
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hs1 = new HashSet<int>(nums2);
            HashSet<int> res = new HashSet<int>();

            foreach (int item in nums1)
            {
                if (hs1.Contains(item))
                {
                    res.Add(item);
                }
            }

            return res.ToArray();
        }

        static void Main(string[] args)
        {
            int[] nums01 = { 1, 2, 2, 1 }, nums02 = { 2, 2 };
            int[] nums11 = { 4, 9, 5 }, nums12 = { 9, 4, 9, 8, 4 };

            int[] res1 = Intersection(nums01, nums02);
            int[] res2 = Intersection(nums11, nums12);
        }
    }
}
