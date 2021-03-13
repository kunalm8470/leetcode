using System;

namespace student_attendance_record
{
	
	class Program
    {
		public static bool CheckRecord(string s)
		{
			int absentDays = 0;
			int consecutiveLateDays = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'A')
				{
					absentDays++;
				}
				else if (s[i] == 'L')
				{
					(bool isConsecutiveLate, int resumptionIndex) = CheckConsecutiveLateness(s, i);
					if (isConsecutiveLate && resumptionIndex != -1)
					{
						consecutiveLateDays++;
						i = resumptionIndex;
					}
				}
			}

			return absentDays < 2 && consecutiveLateDays == 0;
		}

		public static (bool isConsecutiveLate, int resumptionIndex) CheckConsecutiveLateness(string s, int index)
		{
			if (index == s.Length - 1 || index == s.Length - 2)
			{
				return (false, -1);
			}

			int termIndex = index + 3;
			while (index < termIndex)
			{
				if (s[index++] != 'L')
				{
					return (false, -1);
				}
			}

			return (true, index);
		}

		static void Main(string[] args)
        {
			bool res1 = CheckRecord("PPALLP");
			bool res2 = CheckRecord("PPALLL");
		}
    }
}
