public class Solution {
    public int LengthOfLongestSubstring(string s) {
		var maxLength = 0;
		Queue<char> knowChars = [];
		
		for(var right = 0; right < s.Length; right++)
		{
            while(knowChars.Contains(s[right]))
            {
                knowChars.Dequeue();
            }
            knowChars.Enqueue(s[right]);
            maxLength = Math.Max(maxLength, knowChars.Count);   
		}
        return maxLength;
    }
}
