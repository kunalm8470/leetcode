using System;

namespace square_sorted_array
{
    class Program
    {
        public static int[] SortedSquares(int[] nums)
        {
            int[] res = new int[nums.Length];

            int left = 0;
            int right = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    res[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    res[i] = nums[right] * nums[right];
                    right--;
                }
            }

            return res;
        }

        static void Main(string[] args)
        {
            int[] res1 = SortedSquares(new[] { -4, -1, 0, 3, 10 });
            int[] res2 = SortedSquares(new[] { -7, -3, 2, 3, 11 });
        }
    }
}
