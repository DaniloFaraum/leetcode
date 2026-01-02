public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> knowNums = new List<int>{};
        for (int i = 0; i < nums.Length; i++)
        {
            if (knowNums.Contains(nums[i])) return true;
            knowNums.Add(nums[i]);
        }
        return false;
    }
}
