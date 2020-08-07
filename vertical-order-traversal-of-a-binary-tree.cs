public class Solution {
    private void Push(Queue<Tuple<int,TreeNode>> queue,TreeNode node,int x)
    {
        if(node != null)
            queue.Enqueue(new Tuple<int,TreeNode>(x,node));
    }
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        Dictionary<int,IList<int>> dic = new Dictionary<int,IList<int>>();
        Queue<Tuple<int,TreeNode>> queue = new Queue<Tuple<int,TreeNode>>();
        Push(queue,root,0);
        int min = 0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            Dictionary<int,IList<int>> local = new Dictionary<int,IList<int>>();
            for(int i=0;i<size;i++)
            {
                Tuple<int,TreeNode> curr = queue.Dequeue();
                min = Math.Min(curr.Item1,min);
                if(!local.ContainsKey(curr.Item1))
                    local.Add(curr.Item1,new List<int>());
                local[curr.Item1].Add(curr.Item2.val);
                Push(queue,curr.Item2.left,curr.Item1-1);
                Push(queue,curr.Item2.right,curr.Item1+1);
            }
            
            foreach(KeyValuePair<int, IList<int>> entry in local)
            {
                IList<int> list = entry.Value.OrderBy(x=>x).ToList();
                if(!dic.ContainsKey(entry.Key))
                    dic.Add(entry.Key,new List<int>());
                foreach(int x in list)
                    dic[entry.Key].Add(x);
            }
            
        }
        
        IList<IList<int>> ans = new List<IList<int>>();
        for(int i = min;dic.ContainsKey(i);i++)
            ans.Add(dic[i]);
        
        return ans;
    }
}
