
public class Solution {
    public class IndexedNode{
        public TreeNode node;
        public int index;
        public IndexedNode(TreeNode node,int index)
        {
            this.node = node;
            this.index = index;
        }
    }
    public int WidthOfBinaryTree(TreeNode root) {
        Queue<IndexedNode> queue = new Queue<IndexedNode>();
        if(root == null)return 0;
        int max = 0;
        queue.Enqueue(new IndexedNode(root,1));
        int size = queue.Count;
        while(size > 0)
        {
            int first = -1,last=-1;
            for(int i=0;i<size;i++){
                IndexedNode curr = queue.Dequeue();
                if(curr.node.left!=null)
                {
                    IndexedNode left = new IndexedNode(curr.node.left,curr.index*2);
                    queue.Enqueue(left);
                    if(first == -1)first = left.index;
                    last = left.index;
                }
                if(curr.node.right!=null)
                {
                    IndexedNode right = new IndexedNode(curr.node.right,curr.index*2+1);
                    queue.Enqueue(right);
                    if(first == -1)first = right.index;
                    last = right.index;
                }
            }
            max = Math.Max(max,last - first+1);
            size = queue.Count;
        }
        return max;
    }
}
