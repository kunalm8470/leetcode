using System;

namespace two_sum_2
{
    class Program
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            (int, int)[] lookup = new (int, int)[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                lookup[i] = (numbers[i], i);
            }

            Array.Sort(lookup, (a, b) => a.Item1 - b.Item1);

            int start = 0;
            int end = lookup.Length - 1;
            while (start < end)
            {
                int sum = lookup[start].Item1 + lookup[end].Item1;
                if (sum < target)
                {
                    start++;
                }
                else if (sum > target)
                {
                    end--;
                }
                else if (sum == target)
                {
                    return new int[2] { lookup[start].Item2, lookup[end].Item2 };
                }
            }

            throw new Exception("No solution found!");
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
