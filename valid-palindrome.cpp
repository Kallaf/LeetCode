class Solution {
public:
    bool isPalindrome(string s) {
        string temp = "";
        for(int i=0;i<s.length();i++)
            if(('a' <= s[i] && s[i] <= 'z') || ('0' <= s[i] && s[i] <= '9'))
                temp += s[i];
            else if('A' <= s[i] && s[i] <= 'Z')
                temp += s[i]-'A'+'a';
        for(int i=0,j=temp.length()-1;i<temp.length()/2;i++,j--)
            if(temp[i]!=temp[j])return false;
        return true;
    }
};
