public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int n = dungeon.Length-1;
        int m = dungeon[0].Length-1;
        int[][] dp = new int[n+1][];
        for(int i=0;i<=n;i++)
            dp[i] = new int[m+1];
        
        dp[n][m] = Math.Max(1-dungeon[n][m],1);
        for(int i=n-1;i>=0;i--)
            dp[i][m] = Math.Max(dp[i+1][m] - dungeon[i][m],1);
        
        for(int j=m-1;j>=0;j--)
            dp[n][j] = Math.Max(dp[n][j+1] - dungeon[n][j],1);
            
        for(int i=n-1;i>=0;i--)
            for(int j=m-1;j>=0;j--)
                dp[i][j] = Math.Max(Math.Min(dp[i+1][j],dp[i][j+1]) - dungeon[i][j],1);
        
        return dp[0][0];
    }
}
