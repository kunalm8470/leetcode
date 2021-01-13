using System;

namespace merge_sorted_arrays
{
    class Program
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
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

            while(i < m)
            {
                res[k++] = nums1[i++];
            }

            while (j < n)
            {
                res[k++] = nums2[j++];
            }

            for (int l = 0; l < res.Length; l++)
            {
                nums1[l] = res[l];
            }
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            Merge(nums1, m, nums2, n);
        }
    }
}
