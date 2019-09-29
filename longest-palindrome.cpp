class Solution {
public:
    int longestPalindrome(string s) {
        int count[100] = {0};
        for(int i=0;i<s.length();i++)
            count[s[i]-'A']++;
        int one = 0, res = 0;
        for(int i=0;i<90;i++)
        {
            res += count[i] - (count[i]%2);
            if(count[i])cout << (char)(i+'A') << " " << count[i] << endl;
            if(count[i]%2)one = 1;
        }
        return res+one;
    }
};
