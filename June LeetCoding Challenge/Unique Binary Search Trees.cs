public class Solution {
    private int NumTrees(int n,int[] memo)
    {
        if(memo[n] != -1)return memo[n];
        memo[n] = 0;
        for(int i=1;i<=n;i++)
            memo[n] += NumTrees(i-1,memo) * NumTrees(n-i,memo);
        return memo[n];
    }
    public int NumTrees(int n) {
        int[] memo = new int[n+2];
        Array.Fill(memo,-1);
        memo[0] = 1;
        return NumTrees(n,memo);
    }
}
