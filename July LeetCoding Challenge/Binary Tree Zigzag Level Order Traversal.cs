public class Solution {
    private void Push(Stack<TreeNode> stack,TreeNode node)
    {
        if(node != null)
            stack.Push(node);
    }
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        Stack<TreeNode> level = new Stack<TreeNode>();
        bool flag = true;
        Push(level,root);
        IList<IList<int>> ans = new List<IList<int>>();
        while(level.Count > 0)
        {
            Stack<TreeNode> next = new Stack<TreeNode>();
            IList<int> row = new List<int>();
            while(level.Count > 0)
            {
                TreeNode curr = level.Pop();
                row.Add(curr.val);
                if(flag)
                {
                    Push(next,curr.left);
                    Push(next,curr.right);
                }else{
                    Push(next,curr.right);
                    Push(next,curr.left);
                }
            }
            flag = !flag;
            level = next;
            ans.Add(row);
        }
        return ans;
    }
}
