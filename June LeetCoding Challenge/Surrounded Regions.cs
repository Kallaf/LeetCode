public class Solution {
    private static readonly int[] dx = {-1,0,1,0};
    private static readonly int[] dy = {0,-1,0,1};
    private void dfs(char[][] board,int[][] visited,int x,int y,int v)
    {
        if(visited[x][y] != 0)return;
        visited[x][y] = v;
        int n = board.Length;
        int m = board[0].Length;
        for(int i=0;i<4;i++)
        {
            int nx = x+dx[i];
            int ny = y+dy[i];
            if(0 <= nx && nx < n && 0 <= ny && ny <m && board[nx][ny] == 'O')
                dfs(board,visited,nx,ny,v);
        }
    }
    public void Solve(char[][] board) {
        int n = board.Length;
        if(n == 0)return;
        int m = board[0].Length;
        int[][] visited = new int[n][];
        for(int i=0;i<n;i++)
        {
            visited[i] = new int[m];
            Array.Fill(visited[i],0);
        }
        for(int i=0;i<n;i++)
        {
            if(board[i][0] == 'O'&&visited[i][0] == 0)
            {
                dfs(board,visited,i,0,2);
            }
            
            if(board[i][m-1] == 'O'&&visited[i][m-1] == 0)
            {
                dfs(board,visited,i,m-1,2);
            }
        }
        
        for(int j=0;j<m-1;j++)
        {
            if(board[0][j] == 'O'&&visited[0][j] == 0)
            {
                dfs(board,visited,0,j,2);
            }
            
            if(board[n-1][j] == 'O'&&visited[n-1][j] == 0)
            {
                dfs(board,visited,n-1,j,2);
            }
        }
        
        for(int i=1;i<n-1;i++)
        {
            for(int j=1;j<m-1;j++)
            {
                if(board[i][j] == 'O'&&visited[i][j] == 0)
                {
                    dfs(board,visited,i,j,1);
                }
            }
        }
        
        for(int i=1;i<n-1;i++)
        {
            for(int j=1;j<m-1;j++)
            {
                if(visited[i][j] == 1)
                {
                    board[i][j] = 'X';
                }
            }
        }
        
    }
}
