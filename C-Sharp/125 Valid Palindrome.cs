public class Solution {
	public bool IsPalindrome(string s)
	{
		// edge cases
		if (string.IsNullOrEmpty(s))
			return true;
		// normalize input
		var sb = new System.Text.StringBuilder();
		for (int i = 0; i < s.Length; i++)
		{
			if (char.IsLetterOrDigit(s[i]))
				sb.Append(s[i]);
		}

		var finalString = sb.ToString().ToLower();
		// two pointer to check if left an right are the same
		var left = 0;
		var right = finalString.Length - 1;
		while (left < right)
		{
			if (finalString[left] != finalString[right]) return false;
			left++;
			right--;
		}
		return true;
	}
}