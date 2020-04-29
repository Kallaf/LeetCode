class Solution {
    private int max;
    private int maxSum(TreeNode root)
    {
        if(root == null)return Integer.MIN_VALUE;
        int left = maxSum(root.left);
        int right = maxSum(root.right);
        int sum = root.val;
        if(left > 0)sum += left;
        if(right > 0)sum += right;
        max = Math.max(
            max,
            Math.max(sum,Math.max(left,right))
        );
        int maxChild = Math.max(left,right);
        sum = root.val;
        if(maxChild > 0)sum += maxChild;
        return sum;
    }
    public int maxPathSum(TreeNode root) {
        max = Integer.MIN_VALUE;
        maxSum(root);
        return max;
    }
}
