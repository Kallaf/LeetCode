class Solution {
public:
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        vector<int> maxs;
        if(nums.empty())return maxs;
        priority_queue<pair<int,int>> pq;
        for(int i=0;i<k;i++)
          pq.push({nums[i],i});
        maxs.push_back(pq.top().first);
        for(int i=k;i<nums.size();i++)
        {
            while((!pq.empty()) && pq.top().second <= i-k)
                pq.pop();
            pq.push({nums[i],i});
            maxs.push_back(pq.top().first);
        }
        return maxs;
    }
};
