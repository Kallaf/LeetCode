class Solution {
    private Random rand;
    private TreeMap<Integer,int[]> ranges;
    private int totalArea = 0;
    public Solution(int[][] rects) {
        rand = new Random();
        ranges = new TreeMap<>();
        
        for(int[] rect : rects)
        {
            int length = rect[2] - rect[0] + 1 ;
            int width = rect[3] - rect[1] + 1 ;
            totalArea += length*width;
            ranges.put(totalArea,rect);
        }
        
    }
    
    public int[] pick() {
        int[] rect = ranges.get(ranges.ceilingKey(rand.nextInt(totalArea) + 1));
        return new int[]{
            rect[0] + rand.nextInt(rect[2] - rect[0] + 1),
            rect[1] + rand.nextInt(rect[3] - rect[1] + 1)
        };
    }
}
