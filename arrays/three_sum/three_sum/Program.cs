using System;

namespace three_sum
{
    class Program
    {
        static int[] ThreeSum(int[] nums, int target)
        {
            int[] result = new int[3];

            if (nums == default(int[]) || nums.Length == 0)
            {
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int decrTarget = target - nums[i];
                int leftIndex = i + 1;
                int rightIndex = nums.Length - 1;

                for (int j = 1; j < nums.Length; j++)
                {
                    int current = nums[leftIndex] + nums[rightIndex];
                    if (current < decrTarget)
                    {
                        leftIndex += 1;
                    }
                    else if (current > decrTarget)
                    {
                        rightIndex -= 1;
                    }
                    else
                    {
                        result[0] = i;
                        result[1] = leftIndex;
                        result[2] = rightIndex;
                        return result;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 12 };
            int target = 19;
            int[] res = ThreeSum(arr, target);
        }
    }
}
