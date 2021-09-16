class Solution {
    public List<Integer> spiralOrder(int[][] matrix) {
        int[] dx = new int[]{0, 1, 0, -1};
        int[] dy = new int[]{1, 0, -1, 0};
        int n = matrix.length, m = matrix[0].length;
        int total = n * m;
        boolean[][] visited = new boolean[n][m];
        List<Integer> ans = new ArrayList<>();
        for (int i=0,j=0,k=0,l=0;l<total;l++) {
            ans.add(matrix[i][j]);
            visited[i][j] = true;
            i+=dx[k];j+=dy[k];
            if (i == n || j == m || i == -1 || j == -1 || visited[i][j]) {
                i-=dx[k];j-=dy[k];
                k = (k+1)%4;
                i+=dx[k];j+=dy[k];
            }
        }
        return ans;
    }
}
