class Solution {

    private static int[] dx = new int[]{0,1,0,-1};
    private static int[] dy = new int[]{1,0,-1,0};
    
    public int orangesRotting(int[][] grid) {
        if(grid.length==0)return -1;
        Queue<int[]> queue = new LinkedList();
        int freshCount = 0;
		for (int i = 0; i < grid.length; i++) {
			for (int j = 0; j < grid[0].length; j++) {
				if (grid[i][j] == 2)
					queue.add(new int[]{i, j});
				if (grid[i][j] == 1)
					freshCount++;
			}
		}
    int minutes;
    for (minutes=0;!queue.isEmpty() && freshCount > 0;minutes++) {
      int size = queue.size();
      while (size-- > 0) {
        int[] xy = queue.poll();
        for (int i=0;i<4;i++) {
          int x = xy[0] + dx[i];
          int y = xy[1] + dy[i];
          if (x < 0 || y < 0 || x >= grid.length || y >= grid[0].length || grid[x][y] == 0 || grid[x][y] == 2)
            continue;
          queue.add(new int[]{x, y});
          grid[x][y] = 2; 
          freshCount--;
        }
      }
    }

      return freshCount == 0 ? minutes : -1;
    }
    
    
}
