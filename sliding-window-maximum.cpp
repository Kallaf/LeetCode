class Solution {
public:
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        vector<int> maxs;
        if(nums.empty())return maxs;
        deque<int> dq;
        for(int i=0;i<nums.size();i++)
        {
            while((!dq.empty()) && dq.back() <= i-k)dq.pop_back();
            if(dq.empty() || nums[i] > nums[dq.back()])
                dq.push_back(i);
            else
            {
                while((!dq.empty()) && nums[i] >= nums[dq.front()])dq.pop_front();  
                dq.push_front(i);
            }
            if(i>=k-1)maxs.push_back(nums[dq.back()]);
        }
        return maxs;
    }
};
