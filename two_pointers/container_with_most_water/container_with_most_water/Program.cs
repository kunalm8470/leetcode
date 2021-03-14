using System;

namespace container_with_most_water
{
    class Program
    {
		public static int MaxArea(int[] height)
		{
			int left = 0;
			int right = height.Length - 1;
			int maxArea = 0;

			while (left < right)
			{
				int heightLeft = height[left];
				int heightRight = height[right];
				int distance = right - left;

				if (heightLeft < heightRight)
				{
					maxArea = Math.Max(maxArea, heightLeft * distance);
					left++;
				}
				else
				{
					maxArea = Math.Max(maxArea, heightRight * distance);
					right--;
				}
			}

			return maxArea;
		}

		static void Main(string[] args)
        {
			int res1 = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
			int res2 = MaxArea(new int[] { 1, 1});
			int res3 = MaxArea(new int[] { 4, 3, 2, 1, 4 });
			int res4 = MaxArea(new int[] { 1, 2, 1});
		}
    }
}
