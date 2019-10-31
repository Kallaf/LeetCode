class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int mx=0,cnt=0;
        for(int b:nums)
        {
            if(b)cnt++;
            else cnt = 0;
            mx = max(cnt,mx);
        }
        return mx;
    }
};
