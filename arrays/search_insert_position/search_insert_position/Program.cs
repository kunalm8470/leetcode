using System;

namespace search_insert_position
{
    class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums == default(int[]) || nums.Length == 0 || target == 0)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }

            return nums.Length;
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 6 };
            int target1 = 5;
            int target2 = 2;
            int target3 = 7;
            Console.WriteLine(SearchInsert(a, target1));
            Console.WriteLine(SearchInsert(a, target2));
            Console.WriteLine(SearchInsert(a, target3));

            int[] b = { 1, 3 };
            int target4 = 2;
            Console.WriteLine(SearchInsert(b, target4));
        }
    }
}
