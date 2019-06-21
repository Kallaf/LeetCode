class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int ans = 0,n=s.length();
        for(int i=0;i<n;i++)
        {
            int count[10000] = {0};
            int len = 1;
            count[s.at(i)]++;
            ans = max(ans,len);
            for(int j=i+1;j<n;j++)
            {
                count[s.at(j)]++;
                if(count[s.at(j)] > 1)
                    break;
                len++;
                ans = max(ans,len);
            }
        }
        return ans;
    }
};
