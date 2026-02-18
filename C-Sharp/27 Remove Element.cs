public class FirstSolution {
    public int RemoveElement(int[] nums, int val) {
        //remover val's de nums
        //add num de val's em nums em k
        //sort nums so that ->nums[0] -> nums[k] != val
        //return k
        if(nums.Length == 1) return (nums[0] == val) ? 0 : 1;

        var p1 = 0;
        var p2 = nums.Length - 1;
        var temp = 0;
        var k = 0;

        while(p2 >= p1){
            if(nums[p2] == val){
                k++;
                p2--;
                continue;
            }
            if(nums[p1] == val){
                k++;
                temp = nums[p2];
                nums[p2] = nums[p1];
                nums[p1] = temp;
                p2--;
            }
            p1++;
        }
        return nums.Length - k;
    }
}

public class BetterSolution {
    public int RemoveElement(int[] nums, int val) {
        var p1 = 0;
        var p2 = nums.Length - 1;

        while (p1 <= p2) {
            if (nums[p1] == val) {
                nums[p1] = nums[p2];
                p2--;                
                p1++;                
            }
        }
        return p1;
    }
}
