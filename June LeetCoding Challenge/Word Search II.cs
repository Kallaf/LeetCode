public class Solution {
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public String word;
    }
    
     private TrieNode buildTrie(string[] words) {
        TrieNode root = new TrieNode();
        foreach(string w in words) {
            TrieNode current = root;
            foreach (char c in w.ToCharArray()) {
                int i = c - 'a';
                if (current.children[i] == null) 
                  current.children[i] = new TrieNode();
                current = current.children[i];
            }
            current.word = w;
        }
		
        return root;
    }
    private void dfs(char[][] board, int i, int j, TrieNode root, List<string> result) {
        char c = board[i][j];
        if (c == 'V' || root.children[c - 'a'] == null)
            return;
        root = root.children[c - 'a'];
        if (root.word != null) {
            result.Add(root.word);
            root.word = null;
        }
        board[i][j] = 'V';
        //----------------------------------------------------------------
        int[] dx = new int[] {-1,0,1,0};
        int[] dy = new int[] {0,-1,0,1};
        for(int k=0;k<4;k++)
        {
            int ni = i + dx[k];
            int nj = j + dy[k];
            if(0 <= ni && ni < board.Length)
                if(0 <= nj && nj < board[ni].Length)
                    dfs(board,ni,nj,root,result);
        }
        //----------------------------------------------------------------
        board[i][j] = c;
    }
    public IList<string> FindWords(char[][] board, string[] words) {
            List<string> result = new List<string>();
            TrieNode root = buildTrie(words);
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[0].Length; j++) {
                    dfs(board, i, j, root, result);
                }
            }
            return result;
    }
}
