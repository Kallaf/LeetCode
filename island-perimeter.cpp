class Solution {
public:
    int islandPerimeter(vector<vector<int>>& grid) {
        int perimeter = 0;
        int n = grid.size();
        if(!n)return 0;
        int m = grid[0].size();
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                if(grid[i][j])
                {
                    if(i-1<0 || !grid[i-1][j])perimeter++;
                    if(j-1<0 || !grid[i][j-1])perimeter++;
                    if(i+1==n || !grid[i+1][j])perimeter++;
                    if(j+1==m || !grid[i][j+1])perimeter++;
                }
        return perimeter;
    }
};
