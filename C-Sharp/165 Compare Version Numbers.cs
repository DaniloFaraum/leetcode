public class Solution {
    public int CompareVersion(string version1, string version2) {
        // two pointer
        var p1 = 0;
        var p2 = 0;

        while (p1 < version1.Length || p2 < version2.Length) {
            
            var v1CurrentValue = 0;
            var v2CurrentValue = 0;

            while (p1 < version1.Length && version1[p1] != '.') {
                v1CurrentValue = v1CurrentValue * 10 + (version1[p1] - '0');
                p1++;
            }

            while (p2 < version2.Length && version2[p2] != '.') {
                v2CurrentValue = v2CurrentValue * 10 + (version2[p2] - '0');
                p2++;
            }

            if (v1CurrentValue > v2CurrentValue) return 1;
            if (v1CurrentValue < v2CurrentValue) return -1;

            p1++;
            p2++;
        }
        
        return 0;
    }
}
