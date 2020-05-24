public class Solution {
    private TreeNode root;
    private void Insert(int val)
    {
        if(root == null)
        {
            root = new TreeNode(val);
            return;
        }
        TreeNode it = root;
        while(it != null)
        {
            if(val < it.val){
                if(it.left == null)
                {
                    it.left = new TreeNode(val);
                    break;
                }
                else
                    it = it.left;
            }else{
                if(it.right == null)
                {
                    it.right = new TreeNode(val);
                    break;
                }
                else
                    it = it.right;
            }
        }
    }
    public TreeNode BstFromPreorder(int[] preorder) {
        foreach(int val in preorder)Insert(val);
        return root;
    }
}
