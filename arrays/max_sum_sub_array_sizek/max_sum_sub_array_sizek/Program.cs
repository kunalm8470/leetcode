using System;

namespace max_sum_sub_array_sizek
{
    class Program
    {
        public static int FindMaxSumSubArray(int[] nums, int k)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return 0;
            }

            int max = int.MinValue, current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // Add to current in each iteration
                current += nums[i];

                // If approached k, then decrement the value of current by the left most value
                if (i >= k - 1)
                {
                    max = Math.Max(max, current);
                    current -= nums[i - (k - 1)];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            int res1 = FindMaxSumSubArray(new int[] { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 }, 3);
        }
    }
}
