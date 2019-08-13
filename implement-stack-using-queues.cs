public class MyStack {

    private Queue<int> queue = new Queue<int>();
    /** Initialize your data structure here. */
    public MyStack() {
        
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        queue.Enqueue(x);
        int l = queue.Count;
        while(l > 1)
        {
            queue.Enqueue(queue.Dequeue());
            l--;
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        return queue.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        return queue.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
