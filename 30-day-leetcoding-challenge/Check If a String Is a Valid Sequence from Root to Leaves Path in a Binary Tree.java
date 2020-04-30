class Solution {
    public boolean isValidSequence(TreeNode root, int[] arr) {
        return isValid(root,arr,0);
    }
    
    private boolean isValid(TreeNode root,int[] arr,int idx)
    {
        if(idx == arr.length-1 && root != null)
            return arr[idx] == root.val && root.left == null && root.right == null;
        if(idx == arr.length || root == null || root.val != arr[idx])return false;
        return isValid(root.left,arr,idx+1) || isValid(root.right,arr,idx+1);
    }
}
