class Solution {
    public int hIndex(int[] citations) {
        int n = citations.length;
        if(n == 0)
            return 0;
        Arrays.sort(citations);
        int[] max = new int[n];
        max[0] = 0;
        for(int i=1;i<n;i++)
            max[i] = Math.max(max[i-1],citations[i-1]);
        
        for(int i=n-1;i>=0;i--)
        {
            int j = n - i;
            if(max[i] <= j && j <= citations[i])
                return j;
        }
        
        return 0;
    }
}
