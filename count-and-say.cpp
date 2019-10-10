class Solution {
public:
    string countAndSay(int n) {
        if(n == 1)return "1";
        if(n == 2)return "11";
        string pre = countAndSay(n-1);
        string ans = "";
        int count = 1;
        for(int i=1;i<pre.size();i++)
        {
            if(pre[i] == pre[i-1])
                count++;
            else{
                ans += ((char)(count+'0'));
                ans += pre[i-1];
                count = 1;
            }
        }
        ans += ((char)(count+'0'));
        ans += pre[pre.size()-1];
        return ans;
    }
};
