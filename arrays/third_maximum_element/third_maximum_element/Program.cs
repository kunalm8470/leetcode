using System;

namespace third_maximum_element
{
    class Program
    {
        public static int ThirdMax(int[] nums)
        {
            long max = nums[0];
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;

            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = num;
                }

                else if (num < max && num > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }

                else if (num < secondMax && num > thirdMax)
                {
                    thirdMax = num;
                }
            }

            return (thirdMax == long.MinValue) ? Convert.ToInt32(max) : Convert.ToInt32(thirdMax);
        }

        static void Main(string[] args)
        {
            //int res1 = ThirdMax(new int[] { 3, 2, 1 });
            //int res2 = ThirdMax(new int[] { 1, 2 });
            //int res3 = ThirdMax(new int[] { 2, 2, 3, 1 });
            int res4 = ThirdMax(new int[] { 1, 2, -2147483648 });
        }
    }
}
