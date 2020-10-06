using Helper;

namespace ProjectEuler
{
    class Problem4
    {
		internal static void Solve()
		{
			Timer timer = new Timer();
			timer.Begin();
			int answer = GetAnswer();
			Formatting.PrintResult(answer, 4, timer.Stop());
		}

		internal static int GetAnswer()
		{
			int start = 999;
			for (int i = start * start; i >= 0; i--)
			{
				var input = i.ToString();
				if (IsPalindrome(input))
				{
					for (int j = start; j >= start / 2; j--)
					{
						if (i % j == 0 && (i / j).ToString("D").Length == 3)
						{
							return i;
						}
					}
				}
			}
			return -1;
		}

		internal static bool IsPalindrome(string candidate)
		{
			if (candidate.Length == 1)
				return false;

            for (int i = 0; i < candidate.Length / 2; i++)
			{
				var x = i + 1;
				if (candidate[i] != candidate[^x])
					return false;
			}
			return true;
		}
	}
}
