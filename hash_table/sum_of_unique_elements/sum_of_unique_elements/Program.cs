using System;
using System.Collections.Generic;
using System.Linq;

namespace sum_of_unique_elements
{
    class Program
    {
		public static int SumOfUnique(int[] nums)
		{
			Dictionary<int, int> lookup = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (!lookup.ContainsKey(nums[i]))
				{
					lookup[nums[i]] = 1;
				}
				else
				{
					lookup[nums[i]] += 1;
				}
			}

			return lookup.Aggregate(0, (acc, curr) =>
			{
				if (curr.Value == 1)
				{
					return acc + curr.Key;
				}

				return acc;
			});
		}

		static void Main(string[] args)
        {
			int res1 = SumOfUnique(new int[] { 1, 2, 3, 2 });
			int res2 = SumOfUnique(new int[] { 1, 1, 1, 1, 1 });
			int res3 = SumOfUnique(new int[] { 1, 2, 3, 4, 5 });
		}
    }
}
