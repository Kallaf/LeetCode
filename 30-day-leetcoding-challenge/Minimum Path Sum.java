class Solution {
    private int[][] memo;
    private int[][] grid;
    private int n,m;
    
    private int dp(int i,int j)
    {
        if(i == n-1 && j == m-1)return grid[i][j];
        if(i == n || j == m)return Integer.MAX_VALUE;
        if(memo[i][j] != -1)return memo[i][j];
        return memo[i][j] = grid[i][j] + Math.min(dp(i+1,j),dp(i,j+1));
    }
    
    public int minPathSum(int[][] grid) {
        n = grid.length;
        if(n == 0)return 0;
        m = grid[0].length;
        this.grid = grid;
        memo = new int[n][m];
        for(int i=0;i<n;i++)
            Arrays.fill(memo[i],-1);
        return dp(0,0);
    }
}
