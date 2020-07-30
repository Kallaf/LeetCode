public class Solution {
    private int MaxProfit(int[] prices,int cooldown,int day,int[][] dp){
        if(day>=prices.Length)
            return 0;
        if(dp[cooldown][day]!=-1)
            return dp[cooldown][day];
        int x;
        if(cooldown == 0)
            x = MaxProfit(prices,1,day+1,dp) - prices[day];
        else
            x = MaxProfit(prices,0,day+2,dp) + prices[day];
        
        int y = MaxProfit(prices,cooldown,day+1,dp);
        return dp[cooldown][day] = Math.Max(x,y); 
    }
    
    public int MaxProfit(int[] prices) {
        int[][] dp = new int[2][];
        for(int i=0;i<2;i++)
        {
            dp[i] = new int[prices.Length];
            Array.Fill(dp[i],-1);
        }
        return MaxProfit(prices,0,0,dp);
    }
}
