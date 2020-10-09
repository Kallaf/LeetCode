public class Codec {
    private final static String DELIMITER = ",";

    private static TreeNode insertTreeNode(TreeNode root,int val)
    {
        if(root == null)
        { 
            return new TreeNode(val);
        }
        if(val < root.val)
        {
            root.left = insertTreeNode(root.left,val);
        }else{
            root.right = insertTreeNode(root.right,val);
        }
        return root;
    }
    
    // Encodes a tree to a single string.
    public String serialize(TreeNode root) {
        if(root == null)return "";
        String serializedTree = String.valueOf(root.val);
        if(root.left != null)
        {
            String leftSerializedTree = serialize(root.left);
            serializedTree += DELIMITER+leftSerializedTree;
        }
        
        if(root.right != null)
        {
            String rightSerializedTree = serialize(root.right);
            serializedTree += DELIMITER+rightSerializedTree;
        }
        return serializedTree;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(String data) {
        if(data.equals(""))return null;
        String[] nums = data.split(DELIMITER);
        int rootVal = Integer.parseInt(nums[0]);
        TreeNode root = insertTreeNode(null,rootVal);
        for(int i=1;i<nums.length;i++)
        {
            int val = Integer.parseInt(nums[i]);
            insertTreeNode(root,val);
        }
        
        return root;
    }
}
