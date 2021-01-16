using System;

namespace move_zeroes
{
    class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int leftIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[leftIndex];
                    nums[leftIndex] = temp;

                    leftIndex += 1;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 0 };
            MoveZeroes(nums);
        }
    }
}
