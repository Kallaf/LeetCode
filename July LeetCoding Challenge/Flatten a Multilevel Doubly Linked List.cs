public class Solution {
    public Node Flatten(Node head) {
        Node it = head;
        Stack<Node> stack = new Stack<Node>();
        while(it != null)
        {
            if(it.child != null)
            {
                if(it.next != null)
                    stack.Push(it.next);
                it.next = it.child;
                it.child.prev = it;
                it.child = null;
            }
            if(it.next == null && stack.Count > 0)
            {
                Node next = stack.Pop();
                it.next = next;
                next.prev = it;
            }
            it = it.next;
        }
        return head;
    }
}
