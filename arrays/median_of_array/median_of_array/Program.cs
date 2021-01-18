using System;

namespace median_of_array
{
    class Program
    {
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int m = nums1.Length, n = nums2.Length;
			int[] res = new int[m + n];

			int i = 0, j = 0, k = 0;
			while (i < m && j < n)
			{
				if (nums1[i] < nums2[j])
				{
					res[k++] = nums1[i++];
				}

				else
				{
					res[k++] = nums2[j++];
				}
			}

			while (i < m)
			{
				res[k++] = nums1[i++];
			}

			while (j < n)
			{
				res[k++] = nums2[j++];
			}

			double median = 0.0;
			if (res.Length % 2 == 0)
			{
				int prev = (res.Length / 2) - 1;
				int next = res.Length / 2;
				median = (res[prev] + res[next]) / 2.0;
			}
			else
			{
				median = res[res.Length / 2];
			}

			return median;
		}

		static void Main(string[] args)
        {
			double res1 = FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
		}
    }
}
