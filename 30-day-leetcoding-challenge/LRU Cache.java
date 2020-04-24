class LRUCache {

    private int capacity;
    private Map<Integer,Integer> cache;
    private Map<Integer,Integer> count;
    private Queue<Integer> queue;
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.cache = new HashMap<Integer,Integer>();
        this.count = new HashMap<Integer,Integer>();
        this.queue = new LinkedList<Integer>();
    }
    
    public int get(int key) {
        if(cache.containsKey(key))
        {
            queue.add(key);
            count.put(key,count.get(key)+1);
            return cache.get(key);
        }
        return -1;
    }
    
    public void put(int key, int value) {
        queue.add(key);
        cache.put(key,value);
        if(count.containsKey(key))
            count.put(key,count.get(key)+1);
        else
            count.put(key,1);
        while(cache.size() > capacity)
        {
            int temp = queue.remove();
            count.put(temp,count.get(temp)-1);
            if(count.get(temp) == 0)
            {
                count.remove(temp);
                cache.remove(temp);
            }
        }
    }
}
