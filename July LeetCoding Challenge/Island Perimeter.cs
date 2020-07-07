public class Solution {
    private readonly int[] dx = new int[]{-1,0,1,0};
    private readonly int[] dy = new int[]{0,-1,0,1};
    
    public int IslandPerimeter(int[][] grid) {
        int cnt = 0;
        int n = grid.Length;
        int m=grid[0].Length;
        for(int y=0;y<n;y++)
        {
            for(int x=0;x<m;x++)
            {
                if(grid[y][x] == 1)
                {
                    for(int i=0;i<4;i++)
                    {
                        int nx = x + dx[i];
                        int ny = y + dy[i];
                        if(ny < 0 || n <= ny)
                            cnt++;
                        else if(nx < 0 || m <= nx)
                            cnt++;
                        else
                            cnt += grid[ny][nx] ^ 1;
                    }
                }
            }
        }
        return cnt;
    }
}
