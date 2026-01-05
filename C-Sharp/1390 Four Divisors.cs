    public class Solution
    {
        public int SumFourDivisors(int[] nums)
        {
            int sum = 0;
            if (nums.Length == 0) return sum;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                int partialSum = 0;
                int sqrRoot = (int)Math.Sqrt(nums[i]);
                for (int j = 1; j <= sqrRoot; j++)
                {
                    if (nums[i] % j == 0)
                    {
                        count++;
                        partialSum += j;
                        if (j != nums[i] / j)
                        {
                            count++;
                            partialSum += nums[i] / j;
                        }
                    }
                    if (count > 4) break;
                }
                if (count == 4)
                    sum += partialSum;
            }
            return sum;
        }
    }
