public class Solution {
    
    private bool dfs(char[][] board, int i, int j,char[] word,int idx) {
        char c = board[i][j];
        if(idx == word.Length-1)
            return word[idx] == board[i][j];
        
        if (c == '#' || word[idx] != board[i][j])
            return false;
        board[i][j] = '#';
        int[] dx = new int[] {-1,0,1,0};
        int[] dy = new int[] {0,-1,0,1};
        for(int k=0;k<4;k++)
        {
            int ni = i + dx[k];
            int nj = j + dy[k];
            if(0 <= ni && ni < board.Length)
                if(0 <= nj && nj < board[ni].Length)
                    if(dfs(board,ni,nj,word,idx+1))
                        return true;
                    
        }
        board[i][j] = c;
        
        return false;
    }
    
    public bool Exist(char[][] board, string word) {
        char[] wordChars = word.ToCharArray();
        for(int i=0;i<board.Length;i++)
            for(int j=0;j<board[i].Length;j++)
                if(dfs(board,i,j,wordChars,0))
                    return true;
        
        return false;
    }
}
