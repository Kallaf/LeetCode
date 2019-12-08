class Solution {
public:
    bool detectCapitalUse(string word) {
        for(int i=1;i<word.length();i++)
        {
            if(isupper(word[i]) && islower(word[i-1]))
                return false;
            if(i+1 < word.length() && isupper(word[i]) && islower(word[i+1]))
                return false;
            
        }
        return true;
    }
};
