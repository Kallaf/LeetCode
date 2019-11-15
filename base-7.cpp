class Solution {
public:
    string convertToBase7(int num) {
        if(!num)return "0";
        string ans = "";bool neg;
        if(neg = num < 0)num*=-1;
        while(num)
        {
            ans = to_string(num%7) + ans;
            num/=7;
        }
        if(neg)ans = "-" + ans;
        return ans;
    }
};
