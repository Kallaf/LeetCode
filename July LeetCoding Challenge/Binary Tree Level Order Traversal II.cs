public class Solution {
    private void Enqueue(Queue<TreeNode> q,TreeNode node)
    {
        if(node != null)
            q.Enqueue(node);
    }
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<IList<int>> res = new List<IList<int>>();
        Enqueue(queue,root);
        while(queue.Count > 0)
        {
            int size = queue.Count;
            List<int> row = new List<int>();
            for(int i=0;i<size;i++)
            {
                TreeNode node = queue.Dequeue();
                row.Add(node.val);
                Enqueue(queue,node.left);
                Enqueue(queue,node.right);
            }
            res.Add(row);
        }
        res.Reverse();
        return res;
    }
}
