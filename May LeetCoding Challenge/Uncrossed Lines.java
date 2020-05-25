class Solution {
    private int[][] dp;

    private int maxUncrossedLines(int[] A, int[] B,int AStart,int BStart)
    {
        if(AStart == A.length || BStart == B.length)return 0;
        if(dp[AStart][BStart]!=-1)return dp[AStart][BStart];
        dp[AStart][BStart] = 0;
        for(int i=AStart;i<A.length;i++)
        {
            for(int j=BStart;j<B.length;j++)
            {
                if(A[i] == B[j])
                    dp[AStart][BStart] = Math.max(dp[AStart][BStart],1+maxUncrossedLines(A,B,i+1,j+1));
            }
        }
        return dp[AStart][BStart];
    }
    
    public int maxUncrossedLines(int[] A, int[] B) {
        dp = new int[A.length][B.length];
        for (int[] row: dp)
            Arrays.fill(row, -1);
        return maxUncrossedLines(A,B,0,0);
    }
}
