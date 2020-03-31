class Solution {
    public void setZeroes(int[][] matrix) {
        int n=matrix.length,m=0,firstZero=-1;
        if(matrix.length > 0) 
            m = matrix[0].length;
        for(int j=0;j<m;j++)
        {
            boolean zero = false;
            for(int i=0;i<n;i++)
            {
                if(matrix[i][j] == 0)
                {
                    if(firstZero == -1)
                        firstZero = j;
                    zero = true;
                    break;
                }
            }
            if(zero && j != firstZero)
            {
                for(int i=0;i<n;i++)
                {
                    if(matrix[i][j] == 0)
                        matrix[i][firstZero] = 0;
                    matrix[i][j] = 0;
                }
            }
        }
        
        if(firstZero != -1)
        {
            for(int i=0;i<n;i++)
                if(matrix[i][firstZero] == 0)
                    for(int j=0;j<m;j++)
                        matrix[i][j] = 0;

            for(int i=0;i<n;i++)
                matrix[i][firstZero] = 0;
        }
    }
}
