class Solution {
public:
    char findTheDifference(string s, string t) {
        char c = 0;
        for(int i=0;i<s.length();i++)
            c ^= s[i];
        for(int i=0;i<t.length();i++)
            c ^= t[i];
        return c;
    }
};
