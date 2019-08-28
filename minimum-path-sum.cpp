class Solution {
public:
    int minPathSum(vector<vector<int>>& grid) {
        if(grid.empty() || grid[0].empty())return 0;
        int R = grid.size()-1,C = grid[0].size()-1;
        for(int i=R-1;i>=0;i--)
            grid[i][C] += grid[i+1][C];
        for(int j=C-1;j>=0;j--)
            grid[R][j] += grid[R][j+1];
        for(int i=R-1;i>=0;i--)
            for(int j=C-1;j>=0;j--)
                grid[i][j] += min(grid[i+1][j],grid[i][j+1]);
        return grid[0][0];
    }
};
