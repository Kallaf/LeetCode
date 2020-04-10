class MinStack {

    private List<Integer> stack;
    private List<Integer> minStack;
    /** initialize your data structure here. */
    public MinStack() {
        stack = new LinkedList<Integer>();
        minStack = new LinkedList<Integer>();
    }
    
    public void push(int x) {
        stack.add(x);
        if(this.minStack.isEmpty() || x <= this.getMin())
            minStack.add(x);
    }
    
    public void pop() {
        if(this.getMin() == this.top())
            minStack.remove(minStack.size()-1);
        stack.remove(stack.size()-1);
    }
    
    public int top() {
        return stack.get(stack.size()-1);
    }
    
    public int getMin() {
        return minStack.get(minStack.size()-1);
    }
}
