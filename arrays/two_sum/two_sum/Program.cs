using System;
using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return null;
            }

            Dictionary<int, int> lookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                
                if (lookup.ContainsKey(diff))
                {
                    return new int[] { i, lookup[diff] };
                }

                lookup.Add(nums[i], i);
            }

            return new int[2];
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] res = TwoSum(nums, target);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
