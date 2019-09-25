class Solution {
public:
    int firstUniqChar(string s) {
        int count[30] = {0};
        int indexes[30] = {0};
        for(int i=0;i<s.length();i++)
        {
            count[s[i]-'a']++;
            indexes[s[i]-'a'] = i;
        }
        
        int ans = s.length();
        for(int i=0;i<26;i++)
            if(count[i] == 1)
                ans = min(ans,indexes[i]);
        if(ans == s.length())return -1;
        return ans;
    }
};

static int _ = [](){
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    return 0;
}();
