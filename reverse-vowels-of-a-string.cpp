class Solution {
private:
    bool isVowel(char c)
    {
        if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            return true;
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
        return false;
    }
    
public:
    string reverseVowels(string s) {
        string v = "";
        for(int i=s.length()-1;i>=0;i--)
            if(isVowel(s[i]))
                v += s[i];
        for(int i=0,j=0;i<s.length();i++)
        {
            if(isVowel(s[i]))
                s[i] = v[j++];
        }
        return s;
    }
};

static auto _ = [](){
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
};
