class Solution {
public:
    vector<int> intersection(vector<int>& nums1, vector<int>& nums2) {
        unordered_set<int> s1(nums1.begin(),nums1.end());
        unordered_set<int> in;
        for(int num : nums2)if(s1.find(num) != s1.end())in.insert(num);
        vector<int> ans(in.begin(),in.end());
        return ans;
    }
};
