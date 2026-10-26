public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int l = 0;

        for (int r = 1; r < prices.Length; r++)
        {
            if (prices[l] > prices[r])
            {
                l = r;
            }
            else if (prices[r] - prices[l] > result)
            {
                result = prices[r] - prices[l];
            }
        }

        return result;
    }
}
