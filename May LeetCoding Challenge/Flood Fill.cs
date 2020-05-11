public class Solution {
    private int startColor,newColor,n,m;
    private bool[,] visited;
    private int[][] image;
    private static readonly int[] dx = new int[]{-1,0,1,0};
    private static readonly int[] dy = new int[]{0,-1,0,1};
    private void dfs(int x,int y)
    {
        if(visited[x,y])return;
        visited[x,y] = true;
        for(int i=0;i<4;i++)
        {
            int nx = x + dx[i],ny = y + dy[i];
            if(0 <= nx && nx < n)
                if(0 <= ny && ny < m)
                    if(image[nx][ny] == startColor)
                        dfs(nx,ny);
        }
        image[x][y] = newColor;
    }

    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        n = image.Length;
        if(n == 0)return image;
        m = image[0].Length;
        this.image = image;
        visited = new bool[n,m];
        startColor = image[sr][sc];
        this.newColor = newColor;
        dfs(sr,sc);
        return image;
    }
}
