public class Solution {
    
    private int minCross(int[] nums,int l,int m,int r)
    {
        int sum = 0,leftSum = Int32.MaxValue,rightSum = Int32.MaxValue;
        for(int i=m;i>=l;i--)
        {
            sum += nums[i];
            if(sum < leftSum)
                leftSum = sum;
        }
        sum = 0;
        for(int i=m+1;i<=r;i++)
        {
            sum += nums[i];
            if(sum < rightSum)
                rightSum = sum;
        }
        
        return leftSum + rightSum;
    }
    
    private int minSubArray(int[] nums,int l,int r)
    {
        if(l == r)
            return nums[l];
        int m = (l+r)/2;
        
        return Math.Min(
            minCross(nums,l,m,r),
            Math.Min(
                minSubArray(nums,l,m),
                minSubArray(nums,m+1,r)
            )
        );
    }
    
    private int maxCross(int[] nums,int l,int m,int r)
    {
        int sum = 0,leftSum = Int32.MinValue,rightSum = Int32.MinValue;
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
        
        return Math.Max(
            maxCross(nums,l,m,r),
            Math.Max(
                maxSubArray(nums,l,m),
                maxSubArray(nums,m+1,r)
            )
        );
    }
    
    public int MaxSubarraySumCircular(int[] A) {
        int sum = 0;
        foreach(int x in A)sum += x;
        int sub = sum - minSubArray(A,0,A.Length-1);
        int mx = maxSubArray(A,0,A.Length-1);
        if(sub == 0)return mx;
        return Math.Max(mx,sub);
    }
}
