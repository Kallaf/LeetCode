public class MinStack {
    private List<int> list;
    /** initialize your data structure here. */
    public MinStack() {
       list  = new List<int>();
    }
    
    public void Push(int x) {
        list.Add(x);
    }
    
    public void Pop() {
        list.RemoveAt(list.Count - 1);
    }
    
    public int Top() {
        return list[list.Count - 1];
    }
    
    public int GetMin() {
        return list.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
