/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public TreeNode deleteNode(TreeNode root, int key) {
        if(root == null)return null;
        if(root.val == key)
        {
            if(root.left == null)return root.right;
            if(root.right == null)return root.left;
            TreeNode leftLeaf = root.left;
            while(leftLeaf.right != null)leftLeaf = leftLeaf.right;
            leftLeaf.right = root.right;
            return root.left;
        }
        if(root.val < key)
            root.right = deleteNode(root.right,key);
        else
            root.left = deleteNode(root.left,key);
        return root;
    }
}
