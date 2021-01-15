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

            int leftIndex = 0;
            int rightIndex = nums.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentSum = nums[leftIndex] + nums[rightIndex];
                if (currentSum < target)
                {
                    leftIndex += 1;
                }
                else if (currentSum > target)
                {
                    rightIndex -= 1;
                }
                else
                {
                    return new int[2] { leftIndex, rightIndex };
                }
            }

            return new int[2];
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] res = TwoSum(nums, target);
        }
    }
}
