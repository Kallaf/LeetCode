class Solution {
public:
    string longestPalindrome(string s) {
        int n = s.length();
        if(n == 0)return s;
        int memo[n+2][n+2];
        memset(memo,0,sizeof(memo));
        for(int i=0;i<n;i++)memo[i][i] = true;
        int start = 0,len = 1;
        for(int i=1;i<n;i++)
            for(int j=0;j<n-i;j++)
                if(memo[j][j+i] = ((memo[j+1][j+i-1]||i==1) && s[j]==s[j+i]))
                {
                    start = j;
                    len = i+1;
                }
        return s.substr(start,len);
    }
};
