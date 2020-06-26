public class Solution {
    private int SumNumbers(TreeNode root,int prev)
    {
        if(root == null)return 0;
        int curr = prev * 10 + root.val;
        if(root.left == null && root.right == null)return curr;
        return SumNumbers(root.left,curr) + SumNumbers(root.right,curr);
    }
    public int SumNumbers(TreeNode root) {
        return SumNumbers(root,0);
    }
}
