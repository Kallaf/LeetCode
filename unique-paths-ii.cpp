class Solution {
    public int uniquePathsWithObstacles(int[][] obstacleGrid) {
            int n = obstacleGrid.length;
            int m = obstacleGrid[0].length;
            if(obstacleGrid[0][0] == 1)return 0;
            obstacleGrid[0][0] = 1;
            for(int i=1;i<n;i++)
                obstacleGrid[i][0] = obstacleGrid[i][0] == 1?0:obstacleGrid[i-1][0];
            for(int j=1;j<m;j++)
                obstacleGrid[0][j] = obstacleGrid[0][j] == 1?0:obstacleGrid[0][j-1];
            for(int i=1;i<n;i++)
                for(int j=1;j<m;j++)
                    obstacleGrid[i][j] = obstacleGrid[i][j] == 1?0:obstacleGrid[i-1][j] + obstacleGrid[i][j-1];

            return obstacleGrid[n-1][m-1];
    }
}
