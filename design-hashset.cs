public class MyHashSet {

    public class Node{
        public int val;
        public Node left,right;
        public Node(int val=0,Node left=null,Node right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    private Node root;
    /** Initialize your data structure here. */
    public MyHashSet() {
        
    }
    
    public void Add(int key) {
            Node parent = null;
            Node it = root;
            bool l = true;
            while(true)
            {
                if(it == null)
                {
                    it = new Node(key);
                    if(parent != null)
                    {
                        if(l)
                            parent.left = it;
                        else
                            parent.right = it;
                    }else{
                        root = it;
                    }
                    break;
                }else{
                    if(key == it.val)
                        break;
                    
                    parent = it;
                    if(key < it.val)
                    {
                        l = true;
                        it = it.left;
                    }
                    else
                    {
                        l = false;
                        it = it.right;
                    }
                }
            }
    }
    
    public void Remove(int key) {
        Node parent = null;
            Node it = root;
            bool l = true;
            while(true)
            {
                if(it == null)
                    break;
               
                if(key == it.val)
                {
                    Node next;
                    if(it.left != null)
                    {
                        next = it.left;
                        Node succ = it.left;
                        while(succ.right != null)
                            succ = succ.right;
                        
                        succ.right = it.right;
                    }else 
                        next = it.right;
                    
                    if(parent != null)
                    {
                        if(l)
                            parent.left = next;
                        else
                            parent.right = next;
                    }else{
                        root = next;
                    }
                    break;
                }
                
                parent = it;
                if(key < it.val)
                {
                    l = true;
                    it = it.left;
                }
                else
                {
                    l = false;
                    it = it.right;
                }
                
            }
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        Node it = root;
        while(true)
        {
            if(it == null)
                return false;
            
            if(key == it.val)
                return true;

            if(key < it.val)
                it = it.left;
            else
               it = it.right;
        }
        return false;
    }
}
