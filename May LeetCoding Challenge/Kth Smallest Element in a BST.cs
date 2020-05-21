public class Solution {
    private int it = 0,k,ans;
    private bool found = false;
    private void inorder(TreeNode root)
    {
        if(root == null || found)return;
        inorder(root.left);
        it++;
        if(it == k)
        {
            ans = root.val;
            found = true;
        }
        inorder(root.right);
    }
    public int KthSmallest(TreeNode root, int k) {
        this.k = k;
        inorder(root);
        return ans;
    }
}
