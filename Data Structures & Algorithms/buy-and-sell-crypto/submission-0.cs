public class Solution {
    public int MaxProfit(int[] prices) {
        int res = 0;
        int minPrice = int.MaxValue;
        int maxPrice = int.MinValue;
        for (int i = 0; i < prices.Length; i++) {
            int price = prices[i];
            maxPrice = price;
            minPrice = Math.Min(minPrice, price);
            res = Math.Max(res, maxPrice - minPrice);
        }
        return res;
    }
}
