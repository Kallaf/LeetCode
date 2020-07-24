public class Solution {
    private void dfs(int[][] graph,int idx,List<int> path,IList<IList<int>> ans)
    {
        int n = graph.Length;
        if(idx == n-1)
        {
            ans.Add(new List<int>(path));
            return;
        }
        
        foreach(int v in graph[idx])
        {
            path.Add(v);
            dfs(graph,v,path,ans);
            path.RemoveAt(path.Count - 1);
        }

    }
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        IList<IList<int>> ans = new List<IList<int>>();
        List<int> path = new List<int>();
        path.Add(0);
        dfs(graph,0,path,ans);
        return ans;
    }
}
