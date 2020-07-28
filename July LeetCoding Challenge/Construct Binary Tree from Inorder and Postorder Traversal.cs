public class Solution {
    private TreeNode BuildTree(int[] inorder, int[] postorder,int s1,int e1,int s2,int e2) {
        if(e1 < s1)return null;
        if(e2 < s2)return null;
        TreeNode root = new TreeNode(postorder[e2]);
        int ll = 0;
        for(int i=s1;i<=e1&&inorder[i] != root.val;i++,ll++);
        int rl = e1 - s1 - ll;
        root.left = BuildTree(inorder,postorder,
                              s1,s1+ll-1,
                              s2,s2+ll-1);
        root.right = BuildTree(inorder,postorder,
                               s1+ll+1,s1+ll+rl,
                               e2-rl,e2-1);
        return root;
        
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return BuildTree(inorder,postorder,
                         0,inorder.Length-1,
                         0,postorder.Length-1);
    }
}
