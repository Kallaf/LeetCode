public class Solution {
    private void dfs(int idx,List<int>[] edges,bool[] visited,Stack<int> stack)
    {
        if(visited[idx])return;
        visited[idx] = true;
        foreach(int neighbor in edges[idx])
            dfs(neighbor,edges,visited,stack);
        stack.Push(idx);
    }
    
    private bool IsCycle(int idx,List<int>[] edges,bool[] visited)
    {
        if(visited[idx])return true;
        visited[idx] = true;
        foreach(int neighbor in edges[idx])
        {
            if(IsCycle(neighbor,edges,visited))
                return true;
            visited[neighbor] = false;
        }
        return false;
    }
    
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int>[] edges = new List<int>[numCourses];
        for(int i=0;i<numCourses;i++)
          edges[i] = new List<int>();
        
        foreach(int[] prerequisite in prerequisites)
            edges[prerequisite[1]].Add(prerequisite[0]);
        
        
        bool[] visited = new bool[numCourses];
        for(int i=0;i<numCourses;i++)
        {
            if(IsCycle(i,edges,visited))
                return new int[0];
            visited[i] = false;
        }
        
        
        
        Stack<int> stack = new Stack<int>();
        for(int i=0;i<numCourses;i++)
            dfs(i,edges,visited,stack);
        
        int idx = 0;
        int[] ans = new int[numCourses];
        while(stack.Count > 0)
            ans[idx++] = stack.Pop();
        
        return ans;
    }
}
