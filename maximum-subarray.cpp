class Solution {
public:
    int cross(int l,int m,int r,vector<int>& nums)
    {
        int left_sum = INT_MIN,sum=0;
        for(int i=m;i>=l;i--)
        {
            sum += nums[i];
            left_sum = max(sum,left_sum);
        }
        int right_sum = INT_MIN;
        sum=0;
        for(int i=m+1;i<=r;i++)
        {
            sum += nums[i];
            right_sum = max(sum,right_sum);
        }
        return left_sum + right_sum;
    }
    int maxSum(int l,int r,vector<int>& nums)
    {
        if(l == r)
            return nums[l];
        int m = (l+r) >> 1;
        return max(max(maxSum(l,m,nums),maxSum(m+1,r,nums)),cross(l,m,r,nums));
    }
    int maxSubArray(vector<int>& nums) {
       return maxSum(0,nums.size()-1,nums);
    }
    
};
