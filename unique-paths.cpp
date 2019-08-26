class Solution {
    vector<vector<int>> dp;
    private:
    int dfs(int i,int j,int n,int m)
    {
        if(i == n-1 && j == m-1)return 1;
        if(dp[i][j])return dp[i][j];
        int paths = 0;
        if(i+1<n)paths += dfs(i+1,j,n,m);
        if(j+1<m)paths += dfs(i,j+1,n,m);
        dp[i][j] = paths;
        return paths;
    }
public:
    int uniquePaths(int m, int n) {
        vector<int> row(m,0);
        dp.assign(n,row);
        return dfs(0,0,n,m);
    }
};
