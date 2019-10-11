class Solution {
public:
    int longestValidParentheses(string s) {
        int left = 0,right = 0;
        int res = 0;
        int n = s.length();
        for(int i=0;i<n;i++)
        {
            if(s[i] == '(')left++;
            else right++;
            if(left == right)res = max(res,2*right);
            if(right>left)left = right = 0;
        }
        left = right = 0;
        for(int i=n-1;i>=0;i--)
        {
            if(s[i] == '(')left++;
            else right++;
            if(left == right)res = max(res,2*right);
            if(right<left)left = right = 0;
        }
        return res;
    }
};
