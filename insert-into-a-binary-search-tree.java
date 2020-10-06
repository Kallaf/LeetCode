class Solution {
    public TreeNode insertIntoBST(TreeNode root, int val) {
        if(root == null)
        {
            TreeNode insertedNode = new TreeNode();
            insertedNode.val = val;
            return insertedNode;
        }
        if(root.val < val)
        {
            root.right = insertIntoBST(root.right,val);
        }else{
            root.left = insertIntoBST(root.left,val);
        }
        return root;
    }
}
