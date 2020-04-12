class Solution {
    public int lastStoneWeight(int[] stones) {
         PriorityQueue<Integer> pQueue = new PriorityQueue<Integer>(stones.length,Collections.reverseOrder());
        for(int stone:stones)
            pQueue.add(stone);
        while(pQueue.size() > 1)
        {
            int y = pQueue.poll();
            y -= pQueue.poll();
            if(y > 0)
                pQueue.add(y);
        }
        if(pQueue.isEmpty())
            return 0;
        return pQueue.poll();
    }
}
