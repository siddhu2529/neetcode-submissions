public class Solution {
    public int MaxProfit(int[] prices) {
        var buy=prices[0];
        var maxprofit=0;
        foreach( int sell in prices){
            maxprofit = Math.Max(maxprofit, sell-buy);
            buy = Math.Min(buy,sell);
        }
        return maxprofit;
    }
}
