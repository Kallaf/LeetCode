public class Solution {
    
    private List<Tuple<int,int>>[] CreateGraph(int[][] flights,int n)
    {
        List<Tuple<int,int>>[] graph = new List<Tuple<int,int>>[n];
        for(int i=0;i<n;i++)
            graph[i] = new List<Tuple<int,int>>();
        foreach(int[] flight in flights)
            graph[flight[0]].Add(new Tuple<int,int>(flight[1],flight[2]));
        return graph;
    }
    
    private int dfs(List<Tuple<int,int>>[] graph,bool[] visited,int src,int dst,int K,int[][] memo)
    {
        if(src == dst)
            return 0;
        if(K == 0)
            return -1;
        if(memo[src][K] != -1)return memo[src][K];
        int res = int.MaxValue;
        bool flag = false;
        foreach(Tuple<int,int> neighbor in graph[src])
        {
            if(!visited[neighbor.Item1])
            {
                visited[neighbor.Item1] = true;
                int temp = dfs(graph,visited,neighbor.Item1,dst,K-1,memo);
                visited[neighbor.Item1] = false;
                if(temp != -1)
                {
                    int cost = temp + neighbor.Item2;
                    res = Math.Min(res,cost);
                    flag = true;
                }
            }
        }
        return memo[src][K] = flag?res:-1;
    }
    
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        List<Tuple<int,int>>[] graph = CreateGraph(flights,n);
        bool[] visited = new bool[n];
        int[][] memo = new int[n][];
        for(int i=0;i<n;i++)
        {
            memo[i] = new int[K+2];
            Array.Fill(memo[i],-1);
        }
        visited[src] = true;
        return dfs(graph,visited,src,dst,K+1,memo);
    }
}
