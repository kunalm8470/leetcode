using System;
using System.Linq;

namespace missing_number
{
    class Program
    {
        public static int MissingNumber(int[] nums)
        {
            int firstNSum = Convert.ToInt32((nums.Length * (nums.Length + 1)) / 2);

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return firstNSum - sum;
        }

        static void Main(string[] args)
        {
            int res1 = MissingNumber(new int[] { 3, 0, 1 });
            int res2 = MissingNumber(new int[] { 0, 1 });
            int res3 = MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            int res4 = MissingNumber(new int[] { 0 });
        }
    }
}
