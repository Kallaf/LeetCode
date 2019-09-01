/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */

class Solution {
    
    public static List<String> dfs(String s,TreeNode currNode)
    {
        List<String> paths = new ArrayList<String>();
        Integer temp = new Integer(currNode.val);
        String val = temp.toString();
        if(currNode.left != null || currNode.right != null)
        {
            if(currNode.left != null)
            {
                List<String> leftPaths = dfs(s+val+"->",currNode.left);
                for(String path:leftPaths)
                    paths.add(path);
            }
            if(currNode.right != null)
            {
                List<String> rightPaths = dfs(s+val+"->",currNode.right);
                for(String path:rightPaths)
                    paths.add(path);
            }
            
            
            
        }else{
            String t = s + val;
            paths.add(t);
        }
        return paths;
    }
    
    public List<String> binaryTreePaths(TreeNode root) {
        if(root == null)return new ArrayList<String>();
        return dfs("",root);
    }
}
