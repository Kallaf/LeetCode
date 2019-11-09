class Solution {
public:
    vector<int> nextGreaterElement(vector<int>& nums1, vector<int>& nums2) {
        map<int,int> mp;
        stack<int> s;
        for(int num:nums2)
        {
            while(!s.empty() && s.top() < num)
            {
                mp[s.top()] = num;
                s.pop();
            }
            s.push(num);
        }
        vector<int> ans;
        for(int num:nums1)
        {
            if(mp[num])ans.push_back(mp[num]);
            else ans.push_back(-1);
        }
        return ans;
    }
};
