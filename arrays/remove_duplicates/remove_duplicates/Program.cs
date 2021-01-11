using System;
using System.Collections.Generic;

namespace remove_duplicates
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            int res = RemoveDuplicates(nums);
            Console.WriteLine(res);
        }
    }
}
