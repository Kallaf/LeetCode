class Solution {
    public final TreeNode getTargetCopy(final TreeNode original, final TreeNode cloned, final TreeNode target) {
        Queue<TreeNode> q1 = new LinkedList<>();
        Queue<TreeNode> q2 = new LinkedList<>();
        q1.add(original);q2.add(cloned);
        while(!q1.isEmpty())
        {
            TreeNode n1 = q1.remove();
            TreeNode n2 = q2.remove();
            if(n1 == target)return n2;
            AddChilds(q1,n1);
            AddChilds(q2,n2);
        }
        return cloned;
    }
    
    public void AddChilds(Queue<TreeNode> q,TreeNode n)
    {
        if(n.left != null)q.add(n.left);
        if(n.right != null)q.add(n.right);
    }
}
