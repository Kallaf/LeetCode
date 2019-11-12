class Solution {
public:
    vector<string> findWords(vector<string>& words) {
        string temp[3] = {"qwertyuiop","asdfghjkl","zxcvbnm"};
        set<char> row[3];
        for(int i=0;i<3;i++)
            for(char c:temp[i])
                row[i].insert(c);
        vector<string> ans;
        for(string word:words)
        {
            int i=0,yes = 1;
            for(;i<3;i++)
            {
                if (row[i].find(tolower(word[0])) != row[i].end())
                    break;
            }
            assert(i!=3);
            for(int j=1;j<word.length();j++)
            {
                if (row[i].find(tolower(word[j])) == row[i].end())
                {
                    yes = 0;
                    break;
                }
            }
            if(yes)ans.push_back(word);
        }
        return ans;
    }
};
