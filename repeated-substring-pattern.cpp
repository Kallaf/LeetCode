class Solution {
private:
    string str;
    int n;
    bool helper(int len)
    {
        int it = len-1;
        for(int i=len;i<n;i++,it = (it+1)%len)
            if(str[i-len] != str[i])
                return false;
        return it == len-1;
    }
public:
    bool repeatedSubstringPattern(string s) {
        str = s;
        n = s.length();
        for(int i=1;i<=n/2;i++)
            if(helper(i))return true;
        return false;
    }
};

static auto speedup = []()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
};
