class Solution {
    private int count = 0;
    private boolean[] visited = new boolean[16];
    private int n;
    public int countArrangement(int n) {
        this.n = n;
        computeFor(1);
        return count;
    }
    
    private void computeFor(int idx)
    {
        if(n < idx)
        {
            count++;
        }else{
            for(int i=1;i<=n;i++)
            {
                if(!visited[i] && beautiful(i,idx))
                {
                    visited[i] = true;
                    computeFor(idx+1);
                    visited[i] = false;
                }
            }
        }
        
    }
    
    private boolean beautiful(int x,int y)
    {
        return x%y == 0 || y%x == 0;
    }
}
