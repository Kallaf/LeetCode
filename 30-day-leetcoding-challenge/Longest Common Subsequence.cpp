class Solution {
    public int longestCommonSubsequence(String text1, String text2) {
        char[] str1 = text1.toCharArray();
        char[] str2 = text2.toCharArray();
        int n = str1.length,m = str2.length;
        int[][] dp = new int[n+1][m+1];
        Arrays.fill(dp[0],0);
        for(int i=0;i<n;i++)
            dp[i][0] = 0;
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++)
            {
                if(str1[i-1] == str2[j-1])
                    dp[i][j] = dp[i-1][j-1] + 1;
                else
                    dp[i][j] = Math.max(dp[i-1][j],dp[i][j-1]);
            }
        }
        return dp[n][m];
    }
}
