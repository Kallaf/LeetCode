class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        if(strs.empty())
           return ""; 
        string ans = "";
        int n = strs[0].length();
        for(int i=0;i<n;i++)
        {
            char ch = strs[0].at(i);
            bool flag = 0;
            for(int j=1;j<strs.size();j++)
            {
                if(strs[j].length()<=i || strs[j].at(i) != ch)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag)break;
            ans += ch;
        }
        return ans;
    }
};
