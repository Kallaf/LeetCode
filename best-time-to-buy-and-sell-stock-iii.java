class Solution {
    public int maxProfit(int[] prices) {
        int n = prices.length;
        if(n==0)return 0;
        int[] left = new int[n],right = new int[n];
        for(int i=1,min=prices[0];i<n;min=Math.min(min,prices[i]),i++)
            left[i] = Math.max(left[i-1],prices[i] - min);
        for(int i=n-2,max=prices[n-1];i>=0;max=Math.max(max,prices[i]),i--)
            right[i] = Math.max(right[i+1],max - prices[i]);
        int ans = 0;
        for(int i=0;i<n;i++)
            ans = Math.max(ans,left[i]+right[i]);
        return ans;
    }
}
