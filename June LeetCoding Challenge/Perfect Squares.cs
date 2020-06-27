public class Solution {
    public int NumSquares(int n) {
        List<int> squares = new List<int>();
        for(int i=1;i*i<=n;i++)
            squares.Add(i*i);

        int m = squares.Count+1;

        // Creating array which stores subproblems' solutions
        int[][] dp = new int[m][];
        for(int i=0;i<m;i++)
            dp[i] = new int[n+1];

        // Initialising first row with +ve infinity
        for(int j = 0; j <= n; j++){
          dp[0][j] = int.MaxValue;
        }	      

        // Initialising first column with 0
        for(int i = 1; i < m; i++){
          dp[i][0] = 0;
        }

        // Implementing the recursive solution
        for(int i = 1; i < m; i++){
          for(int j = 1; j <= n; j++){
              if(squares[i - 1] <= j)
                  dp[i][j] = Math.Min(1 + dp[i][j - squares[i - 1]], dp[i - 1][j]);
              else
                  dp[i][j] = dp[i - 1][j];
          }
        }

        return dp[m-1][n];

    }
}
