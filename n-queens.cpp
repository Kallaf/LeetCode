class Solution {
    private:
        bitset<30> rw, ld, rd; // for the largest n = 14, we have 27 diagonals
        vector<vector<string>> ans;
        void backtrack(int c,int n,vector<string> board) {
            if (c == n) 
            { 
                ans.push_back(board);
                return;
            } // a solution
            for (int r = 0; r < n; r++) // try all possible row
                if (!rw[r] && !ld[r - c + n - 1] && !rd[r + c]) {
                    rw[r] = ld[r - c + n - 1] = rd[r + c] = true; // flag off
                    board[c][r] = 'Q';
                    backtrack(c + 1,n,board);
                    board[c][r] = '.';
                    rw[r] = ld[r - c + n - 1] = rd[r + c] = false; // restore
                } 
        }
    public:
        vector<vector<string>> solveNQueens(int n) {
            vector<string> board;
            for(int i=0;i<n;i++)
            {
                string row = "";
                for(int j=0;j<n;j++)
                    row += ".";
                board.push_back(row);
            }
            backtrack(0,n,board);
            return ans;
        }
};
