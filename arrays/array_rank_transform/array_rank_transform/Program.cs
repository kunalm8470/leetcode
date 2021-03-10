using System;

namespace array_rank_transform
{
    class Program
    {
        public static int[] ArrayRankTransform(int[] arr)
		{
			(int, int)[] lookup = new (int, int)[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				lookup[i] = (arr[i], i);
			}

			Array.Sort(lookup, (a, b) => a.Item1 - b.Item1);

			int[] res = new int[arr.Length];
			int rank = 1;

			for (int i = 0; i < lookup.Length; i++)
			{
				if (i > 0 && lookup[i - 1].Item1 != lookup[i].Item1)
				{
					rank += 1;
				}

				res[lookup[i].Item2] = rank;
			}

			return res;
		}

		static void Main(string[] args)
        {
			int[] res1 = ArrayRankTransform(new [] { 40, 40, 30, 20, 20, -1 });
			int[] res2 = ArrayRankTransform(new[] { 100, 100, 100 });
			int[] res3 = ArrayRankTransform(new[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
        }
    }
}
