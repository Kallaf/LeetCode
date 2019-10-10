class Solution {
private:
    string s,p;
    vector<vector<int>> dp;
    int backtrack(int i,int j)
    {
        if(j >= p.length()) return i>=s.length();
        int& res = dp[i][j];
        if(res != -1)return res;
        bool eq = (i<s.length() && (p[j] == s[i] || p[j] == '.'));
        
        if(j+2 <= p.length() && p[j+1] == '*')
            return res = (int)(backtrack(i,j+2) || (eq && backtrack(i+1,j)));
        
        return res = (int)(eq && backtrack(i+1,j+1));
    }
public:
    bool isMatch(string text, string pattern) {
        s = text;
        p = pattern;
        dp.assign(s.size()+3,vector<int>(p.size()+3,-1));
        return (bool)backtrack(0,0);
    }
};
