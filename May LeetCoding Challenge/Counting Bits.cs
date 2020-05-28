public class Solution {
    public int[] CountBits(int num) {
        int[] dp = new int[num+1];
        dp[0] = 0;
        int next2Pow = 1;
        for(int i=1,j=0;i<=num;i++)
        {
            if(i == next2Pow)
            {
                j=0;
                next2Pow <<= 1;
            }
            dp[i] = dp[j++] + 1;
        }
        return dp;
    }
}
