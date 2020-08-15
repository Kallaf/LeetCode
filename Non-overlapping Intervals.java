class Solution {
    public int eraseOverlapIntervals(int[][] intervals) {
        Arrays.sort(intervals,(a,b) -> a[1] == b[1] ? b[0] - a[0]: a[1] - b[1]);
        int res = 0;
        int end = Integer.MIN_VALUE;
        for(int[] interval:intervals)
        {
            if(end > interval[0])res++;
            else end = interval[1];
        }
        return res;
    }
}
