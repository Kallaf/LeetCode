class Solution {
 private:
    string s,p;
    int n,m;
    vector<vector<int>> memo;
    bool areMatching(int i,int j)
    {
        if(j>=m)return i>=n;
        int& res = memo[i][j];
        if(res != -1)return res;
        if(p[j] == '*')
        {
            for(int k=i;k<=n;k++)
            {
                bool match = areMatching(k,j+1);
                if(match)return res = 1;
            }
            return res = 0;
        }
        bool currMatch = (i<n && (s[i] == p[j] || p[j] == '?'));
        return res = currMatch && areMatching(i+1,j+1);
    }
    
public:
    bool isMatch(string text, string pattern) {
        s = text;p = pattern;
        n = text.length();
        m = pattern.length();
        memo.assign(n+2,vector<int>(m+2,-1));
        return areMatching(0,0);
    }
};
