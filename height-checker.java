class Solution {
    public int heightChecker(int[] heights) {
        int[] sorted = heights.clone();
        Arrays.sort(sorted);
        int ans = 0;
        for(int i=0;i<sorted.length;i++)
            if(sorted[i] != heights[i])
                ans++;
        return ans;
    }
}
