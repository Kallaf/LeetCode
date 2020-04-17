class Solution {
    private char[][] grid;
    private static final int[] dx = new int[] {-1,0,1,0};
    private static final int[] dy = new int[] {0,-1,0,1};
    private int n,m;
    private void dfs(int x,int y)
    {
        grid[x][y] = '0';
        for(int i=0;i<4;i++)
        {
            int nx = x + dx[i], ny = y + dy[i];
            if(nx < 0 || this.n <= nx)continue;
            if(ny < 0 || this.m <= ny)continue;
            if(this.grid[nx][ny] == '0')continue;
            dfs(nx,ny);
        }
    }
    public int numIslands(char[][] grid) {
        this.n = grid.length;
        if(n == 0)return 0;
        this.m = grid[0].length;
        this.grid = grid;
        int cnt = 0;
        for(int i=0;i<grid.length;i++)
        {
            for(int j=0;j<grid[i].length;j++)
            {
                if(grid[i][j] == '1')
                {
                    dfs(i,j);
                    cnt++;
                }
            }
        }
        return cnt;
    }
}
