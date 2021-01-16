using System;

namespace two_sum_2
{
    class Program
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            if (numbers == default(int[]) || numbers.Length == 0)
            {
                return result;
            }

            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[leftIndex] + numbers[rightIndex];
                if (current < target)
                {
                    leftIndex += 1;
                }
                else if (current > target)
                {
                    rightIndex -= 1;
                }
                else
                {
                    result[0] = leftIndex + 1;
                    result[1] = rightIndex + 1;
                    return result;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Pre-condition is that array will be sorted
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;
            int[] res = TwoSum(arr, target);
        }
    }
}
