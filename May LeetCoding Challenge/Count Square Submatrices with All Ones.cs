public class Solution {
    private int n,m;
    private int getCount(int[,] sum,int x,int y)
    {
        int count = 0;
        for(int size=1;size-1<=x && size-1<=y;size++)
        {
            int i = x - size;
            int j = y - size;
            int squareSum = sum[x,y];
            if(i>=0)squareSum -= sum[i,y];
            if(j>=0)squareSum -= sum[x,j];
            if(i>=0 && j>=0)squareSum += sum[i,j];
            if(squareSum == size * size)count++;
            else return count;
        }
        return count;
    }
    public int CountSquares(int[][] matrix) {
        n = matrix.Length;
        if(n == 0)return 0;
        m = matrix[0].Length;
        int[,] sum = new int[n+1,m+1];
        sum[0,0] = matrix[0][0];
        for(int i=1;i<n;i++)sum[i,0] = matrix[i][0] + sum[i-1,0];
        for(int j=1;j<m;j++)sum[0,j] = matrix[0][j] + sum[0,j-1];
        for(int i=1;i<n;i++)
            for(int j=1;j<m;j++)
                sum[i,j] = matrix[i][j] + sum[i-1,j] + sum[i,j-1] - sum[i-1,j-1];
        int count = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
                count += getCount(sum,i,j);
        }
        return count;
    }
}
