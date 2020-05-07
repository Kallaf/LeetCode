class Solution {
    public boolean isCousins(TreeNode root, int x, int y) {
        Queue<TreeNode> queue = new LinkedList<>();
        queue.add(root);
        while(!queue.isEmpty())
        {
            int size = queue.size();
            boolean xf = false,yf = false;
            for(int i=0;i<size;i++)
            {
                TreeNode head = queue.remove();
                if(head.val == x)xf = true;
                if(head.val == y)yf = true;
                if(head.left != null)queue.add(head.left);
                if(head.right != null)queue.add(head.right);
                if(head.left != null && head.right != null)
                {
                    if(head.left.val == x && head.right.val == y)return false;
                    if(head.left.val == y && head.right.val == x)return false;
                }
            }
            if(xf)return yf;
            if(yf)return xf;
        }
        return false;
    }
}
