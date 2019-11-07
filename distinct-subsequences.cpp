class Solution {
public:
    int numDistinct(string s, string t) {
        map<char,vector<int>> indexes;
        for(int i=0;i<t.length();i++)indexes[t[i]].push_back(i);
        long long dp[t.length()+1] = {0};
        for(int i=0;i<s.length();i++)
        {
            for(int j=indexes[s[i]].size()-1;j>=0;j--)
            {
                int index = indexes[s[i]][j];
                if(index == 0)dp[index]++;
                else dp[index] += dp[index-1];
            }
        }
        return dp[t.length()-1];
    }
};
