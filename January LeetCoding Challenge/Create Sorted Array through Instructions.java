class Solution {
    public int createSortedArray(int[] instructions) {
        Node root = constructTree(instructions);
        int cost = 0;
        for(int instruction:instructions)
        {
            root = insert(root,instruction);
            cost = (cost + Math.min(root.smallerDTO,root.largerDTO)) % 1000000007;
        }
        return cost;
    }
    
    private Node constructTree(int[] instructions)
    {
        int sorted[] = instructions.clone();
        Arrays.sort(sorted);
        int distinct[] = new int[sorted.length];
        int n = 1;
        distinct[0] = sorted[0];
        for(int i=1;i<sorted.length;i++)
            if(sorted[i] != sorted[i-1])
                distinct[n++] = sorted[i];
        return sortedArrayToBST(distinct,0,n-1);
    }
    
    private Node sortedArrayToBST(int arr[], int start, int end) { 
        if (start > end)return null; 
        int mid = (start + end) / 2; 
        Node node = new Node(arr[mid]);
        node.left = sortedArrayToBST(arr, start, mid - 1);
        node.right = sortedArrayToBST(arr, mid + 1, end); 
        return node; 
    } 
    
    private Node insert(Node root,int val)
    {
        if(root.val > val){
            root.smaller++;
            root.left = insert(root.left,val);
            root.smallerDTO = root.left.smallerDTO;
            root.largerDTO = root.left.largerDTO + root.count + root.larger;
        }else if(root.val < val){
            root.larger++;
            root.right = insert(root.right,val);
            root.smallerDTO = root.right.smallerDTO + root.smaller + root.count;
            root.largerDTO = root.right.largerDTO;
        }else{
            root.count++;
            root.smallerDTO = root.smaller;
            root.largerDTO = root.larger;
        }
        return root;
    }

    class Node{
        int val;
        Node left;
        Node right;
        int count;
        int smaller;
        int larger;
        int smallerDTO;
        int largerDTO;
        
        public Node(int val)
        {
            this.val = val;
        }
        
        public Node(int smaller,int larger)
        {
            this.smallerDTO = smaller;
            this.largerDTO = larger;
        }
    }
}
