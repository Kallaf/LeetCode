class Solution {
    
    private int maxCross(int[] nums,int l,int m,int r)
    {
        int sum = 0,leftSum = Integer.MIN_VALUE,rightSum = Integer.MIN_VALUE;
        for(int i=m;i>=l;i--)
        {
            sum += nums[i];
            if(sum > leftSum)
                leftSum = sum;
        }
        sum = 0;
        for(int i=m+1;i<=r;i++)
        {
            sum += nums[i];
            if(sum > rightSum)
                rightSum = sum;
        }
        
        return leftSum + rightSum;
    }
    
    private int maxSubArray(int[] nums,int l,int r)
    {
        if(l == r)
            return nums[l];
        int m = (l+r)/2;
        
        return Math.max(
            maxCross(nums,l,m,r),
            Math.max(
                maxSubArray(nums,l,m),
                maxSubArray(nums,m+1,r)
            )
        );
    }
    
    public int maxSubArray(int[] nums) {
           return maxSubArray(nums,0,nums.length-1);
    }
}
