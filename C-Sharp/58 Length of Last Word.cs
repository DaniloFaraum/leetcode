public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int wordLength = 0;
        while(s[i] == ' ') i--;
        while(i >= 0 && s[i] != ' '){
            wordLength++;
            i--;
        }
        return wordLength;
    }
}
