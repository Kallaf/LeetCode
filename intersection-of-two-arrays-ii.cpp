class Solution {
public:
    vector<int> intersect(vector<int>& nums1, vector<int>& nums2) {
        map<int,int> m1;
        for(int i=0;i<nums1.size();i++)
            if(m1.count(nums1[i]) == 0)
                m1[nums1[i]] = 1;
            else
                m1[nums1[i]]++;
        map<int,int> m2;
        for(int i=0;i<nums2.size();i++)
            if(m1.count(nums2[i]))
            {
                if(m2.count(nums2[i]) == 0)
                    m2[nums2[i]] = 1;
                else
                    m2[nums2[i]]++;   
            }
        vector<int> ans;
        for(auto i=m2.begin();i!=m2.end();i++)
        {
            if(i->first == 55)
                cout << m1[i->first] << " " << i->second << endl;
            int n = min(m1[i->first],i->second);
            for(int j=0;j<n;j++)
                ans.push_back(i->first);
        }
        return ans;
    }
};
