public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int minPrice = int.MaxValue;
        foreach(int price in prices){
            minPrice = Math.Min(minPrice, price);
            res = Math.Max(res, price - minPrice);
        }
        return res;
    }
}
