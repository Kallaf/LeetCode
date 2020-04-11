class Solution {
    private int mx = 0;
    
    private int getHeight(TreeNode root)
    {
        if(root == null)return 0;
        int leftHeight = getHeight(root.left);
        int rightHeight = getHeight(root.right);
        mx = Math.max(mx,leftHeight + rightHeight);
        return Math.max(leftHeight,rightHeight) + 1;
    }
    
    public int diameterOfBinaryTree(TreeNode root) {
        getHeight(root);
        return mx;
    }
}
