class Solution {
public:
    vector<string> findRelativeRanks(vector<int>& nums) {
        if(nums.empty())return {};
        vector<pair<int,int>> vec;
        for(int i=0;i<nums.size();i++)vec.push_back({nums[i],i});
        sort(vec.begin(),vec.end(),greater<pair<int,int>>());
        vector<string> ans(nums.size());
        ans[vec[0].second] =   "Gold Medal";
        if(nums.size() == 1)return ans;
        ans[vec[1].second] = "Silver Medal";
        if(nums.size() == 2)return ans;
        ans[vec[2].second] = "Bronze Medal";
        for(int i=3;i<vec.size();i++)ans[vec[i].second] = to_string(i+1);
        return ans;
    }
};
