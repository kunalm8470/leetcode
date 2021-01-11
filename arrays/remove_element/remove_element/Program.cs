using System;

namespace remove_element
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == default(int[]) || nums.Length == 0)
            {
                return 0;
            }

            int idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[idx++] = nums[i];
                }
            }

            return idx;
        }

        static void Main(string[] args)
        {
            int[] inp = { 3, 2, 2, 3 };
            int val = 3;
            int res = RemoveElement(inp, val);
            Console.WriteLine(res);
        }
    }
}
