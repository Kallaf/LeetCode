class Solution {
    private int length = 0,n,m;
    private boolean isSquare(int r,int c,char[][] matrix)
    {
        int rEnd = r + length;
        int cEnd = c + length;
        
        if(rEnd >= n || cEnd >= m)return false;
        for(int i=r;i<=rEnd;i++)
            for(int j=c;j<=cEnd;j++)
                if(matrix[i][j] == '0')
                    return false;
        return true;
    }
    public int maximalSquare(char[][] matrix) {
        n = matrix.length;
        if(n == 0)return 0;
        m = matrix[0].length;
        for(int j=0;j<m;j++)
            for(int i=0;i<n;i++)
                if(matrix[i][j] == '1')
                    while(isSquare(i,j,matrix))
                        length++;
        
        return length*length;
    }
}
