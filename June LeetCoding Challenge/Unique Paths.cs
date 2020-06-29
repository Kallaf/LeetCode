public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] dp = new int[n+1][];
        for(int i=0;i<n;i++)
        {
            dp[i] = new int[m+1];
            dp[i][0] = 1;
        }
        for(int j=0;j<m;j++)
            dp[0][j] = 1;
        for(int i=1;i<n;i++)
            for(int j=1;j<m;j++)
                dp[i][j] = dp[i-1][j] + dp[i][j-1];
        return dp[n-1][m-1];
    }
}
