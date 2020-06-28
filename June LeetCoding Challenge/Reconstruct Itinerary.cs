public class Solution {
    public class Airport{
        private int idx;
        private List<string> dest;
        public Airport()
        {
            idx = 0;
            dest = new List<string>();
        }
        public bool HasNext()
        {
            return idx < dest.Count;
        }
        public void AddDestination(string to)
        {
            dest.Add(to);
            int j = dest.Count - 2;
            while ((j >= 0) && (dest[j].CompareTo(to) > 0))
            {
                dest[j + 1] = dest[j];
                j--;
            }
            dest[j + 1] = to;
        }
        public string Next()
        {
            return dest[idx++];
        }
    }
    private void dfs(Dictionary<string,Airport> map,List<string> path,string src)
    {
        Airport airport = map[src];
        while(airport.HasNext())
            dfs(map,path,airport.Next());
        path.Add(src);
    }
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        Dictionary<string,Airport> map = new Dictionary<string,Airport>();
        foreach(List<string> ticket in tickets)
        {
            if(!map.ContainsKey(ticket[0]))
                map.Add(ticket[0],new Airport());
            if(!map.ContainsKey(ticket[1]))
                map.Add(ticket[1],new Airport());
            map[ticket[0]].AddDestination(ticket[1]);
        }
        List<string> path = new List<string>();
        dfs(map,path,"JFK");
        path.Reverse();
        return path;
    }
}
