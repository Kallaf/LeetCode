class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        bool hasFirst = 1;
        for(int i=0;i<digits.size();i++)
            if(digits[i] != 9)
            {
                hasFirst = 0;
                break;
            }
        vector<int> ans;
        if(hasFirst)
        {
            ans.push_back(1);
            for(int i=0;i<digits.size();i++)
                ans.push_back(0);
        }else
        {
            for(int i=digits.size()-1;i>-1;i--)
            {
                if(digits[i] == 9)
                    digits[i] = 0;
                else
                {
                    digits[i]++;
                    break;
                }
            }
            for(int i=0;i<digits.size();i++)
                ans.push_back(digits[i]);
        }
        return ans;
    }
};
