class Solution {
public:
    string toHex(int num) {
        if(!num)return "0";
        unsigned int n = num;
        string ans = "";
        while(n)
        {
            int rem = n & 0xF;
            n>>=4;
            if(rem<10)ans += (rem+'0');
            else ans += (rem-10+'a');
        }
        reverse(ans.begin(), ans.end());
        return ans;
    }
};
