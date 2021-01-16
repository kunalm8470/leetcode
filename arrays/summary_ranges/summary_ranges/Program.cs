using System;
using System.Collections.Generic;

namespace summary_ranges
{
    class Program
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> res = new List<string>();
            if (nums == default(int[]) || nums.Length == 0)
            {
                return res;
            }

            if (nums.Length == 1)
            {
                res.Add(nums[0].ToString());
                return res;
            }

            for (int end = 0, start = 0; end < nums.Length; end++, start = end)
            {
                while(end < nums.Length - 1 && nums[end] == nums[end + 1] - 1)
                {
                    end += 1;
                }

                if (end != start)
                {
                    res.Add(string.Format("{0}->{1}", nums[start], nums[end]));
                }
                else
                {
                    res.Add(nums[end].ToString());
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            IList<string> res1 = SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 });
            IList<string> res2 = SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });
        }
    }
}
