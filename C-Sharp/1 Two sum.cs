public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            // checar se chave com valor atual existe
            if (dict.ContainsKey(nums[i])){
            // se sim retornar atual, dict[valor atual]
                return [i, dict[nums[i]]];
            }
            // adicionar no dict o numero q completa pra target, indice ex: 7, 0
            dict.TryAdd(target - nums[i], i);
        }
        return [0,0];
    }
}
