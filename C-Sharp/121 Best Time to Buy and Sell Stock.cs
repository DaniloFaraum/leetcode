public class Solution {
    public int MaxProfit(int[] prices) {
        var buy = 0;
        var sell = 1;
        var profit = 0;
        var cheapest = prices[0];

        while(sell < prices.Length){
            var transaction = prices[sell] - prices[buy];
            if (transaction > profit){
                profit = transaction;
            }
            if (prices[sell] < cheapest){
                cheapest = prices[sell];
                buy = sell;
            }
            sell++;
        }
        return profit;
    }
}// atualirzar proit e o buy
