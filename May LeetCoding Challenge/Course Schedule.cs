public class Solution {
    private bool IsCycle(int idx,List<int>[] edges,bool[] visitedGlobal,bool[] visitedLocal)
    {
        if(visitedGlobal[idx])return visitedLocal[idx];
        visitedLocal[idx] = visitedGlobal[idx] = true;
        for(int i=0;i<edges[idx].Count;i++)
            if(IsCycle(edges[idx][i],edges,visitedGlobal,visitedLocal))
                return true;
            else
                visitedLocal[edges[idx][i]] = false;
                
        return false;
    }
        
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] edges = new List<int>[numCourses];
        for(int i=0;i<numCourses;i++)edges[i] = new List<int>();
        for(int i=0;i<prerequisites.Length;i++)
            edges[prerequisites[i][0]].Add(prerequisites[i][1]);
        bool[] visitedGlobal = new bool[numCourses];
        for(int i=0;i<numCourses;i++)
            if(!visitedGlobal[i] && IsCycle(i,edges,visitedGlobal,new bool[numCourses]))
                return false;
        return true;
    }
}
