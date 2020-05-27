public class Solution {
    private bool conflictsExists(int idx,int N,List<int>[] hates,bool[] visited)
    {
        int[] type = new int[N+1];
        Array.Fill(type,-1);
        type[idx] = 0;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(idx);
        while(queue.Count > 0)
        {
            int curr = queue.Dequeue();
            foreach(int hate in hates[curr])
            {
                if(type[hate] == -1)
                    type[hate] = 1 - type[curr];
                else if(type[hate] != 1 - type[curr])
                    return true;
                if(!visited[hate])
                    queue.Enqueue(hate);
            }
            visited[curr] = true;
        }
        return false;
    }
    public bool PossibleBipartition(int N, int[][] dislikes) {
        List<int>[] hates = new List<int>[N+1];
        for(int i=1;i<=N;i++)hates[i] = new List<int>();
        foreach(int[] dislike in dislikes)
        {
            hates[dislike[0]].Add(dislike[1]);
            hates[dislike[1]].Add(dislike[0]);
        }
        
        bool[] visited = new bool[N+1];
        for(int i=1;i<=N;i++)
            if(!visited[i]&&conflictsExists(i,N,hates,visited))
                return false;
        return true;
    }
}
