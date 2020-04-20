class Solution {
    private void insert(TreeNode parent,TreeNode node)
    {
        if(node.val < parent.val)
        {
            if(parent.left == null)
                parent.left = node;
            else
                insert(parent.left,node);
        }else{
            if(parent.right == null)
                parent.right = node;
            else
                insert(parent.right,node);
        }
    }
    public TreeNode bstFromPreorder(int[] preorder) {
        if(preorder.length == 0)return null;
        TreeNode root = new TreeNode(preorder[0]);
        for(int i=1;i<preorder.length;i++)
            insert(root,new TreeNode(preorder[i]));
        return root;
    }
}
