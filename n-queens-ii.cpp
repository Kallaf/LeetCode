class Solution {
    
    private:
        bitset<30> rw, ld, rd; // for the largest n = 14, we have 27 diagonals
        int ans = 0;
        void backtrack(int c,int n) {
            if (c == n) 
            { 
                ans++;
                return;
            } // a solution
            for (int r = 0; r < n; r++) // try all possible row
                if (!rw[r] && !ld[r - c + n - 1] && !rd[r + c]) {
                    rw[r] = ld[r - c + n - 1] = rd[r + c] = true; // flag off
                    backtrack(c + 1,n);
                    rw[r] = ld[r - c + n - 1] = rd[r + c] = false; // restore
                } 
        }
    
    public:
        int totalNQueens(int n) {
            backtrack(0,n);
            return ans;
        }
};
