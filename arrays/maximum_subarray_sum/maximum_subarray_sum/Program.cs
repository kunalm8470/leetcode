using System;

namespace maximum_subarray_sum
{
    class Program
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            // Kadane's algorithm

            int maxSum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                // To find max sum upto that point
                currentSum = Math.Max(nums[i] + currentSum, nums[i]);

                // Compare the max of currentSum and maxSum
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum1 = MaxSubArray(arr1);
            Console.WriteLine(maxSum1);
        }
    }
}
