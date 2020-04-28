class FirstUnique {

    private Set<Integer> unique,nonUnique;
    private Queue<Integer> queue;
    
    public FirstUnique(int[] nums) {
        this.unique = new HashSet<Integer>();
        this.nonUnique = new HashSet<Integer>();
        this.queue = new LinkedList<Integer>();
        for(int num:nums)this.add(num);
        
    }
    
    public int showFirstUnique() {
        while(!this.queue.isEmpty())
        {
            if(this.nonUnique.contains(this.queue.peek()))
                this.queue.remove();
            else
                break;
        }
        if(this.queue.isEmpty())
            return -1;
        return this.queue.peek();
    }
    
    public void add(int value) {
        if(this.unique.contains(value))
        {
            this.unique.remove(value);
            this.nonUnique.add(value);
        }else if(!this.nonUnique.contains(value))
        {
            this.unique.add(value);
            this.queue.add(value);
        }
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.showFirstUnique();
 * obj.add(value);
 */
