public class Solution {
    public int MajorityElement(int[] nums) {
        var majority = 0;
        var res = nums[0];

        for(int i = 0; i < nums.Length; i++){
            if (majority == 0) res = nums[i];
            if (nums[i] == res) majority++;
            else majority --;
        }
        return res;
    }
}

public class FirstSolution {
    public int MajorityElement(int[] nums) {
        var frequency = new Dictionary<int, int>();
        var majority = 0;
        var res = nums[0];

        for (int i = 0; i < nums.Length; i++){
            if (!frequency.TryAdd(nums[i],1)){
                frequency[nums[i]]++;
                if (frequency[nums[i]] > majority){
                    majority = frequency[nums[i]];
                    res = nums[i];
                } 
            }
        }
        return res;
    }
}
