class Solution {
public:
    string addBinary(string a, string b) {
        char carry = 0;
        vector<char> sum;
        int first = min(a.length(),b.length());
        int last = max(a.length(),b.length());
        for(int i=0;i<first;i++)
        {
            int x = a[a.length()-1-i]-'0',y = b[b.length()-1-i] - '0';
            sum.push_back((x^y^carry)?'1':'0');
            carry = (x&y)|(x&carry)|(carry&y);
        }
        if(a.length() == first)
        {
            for(int i=first;i<b.length();i++)
            {
                int y = b[b.length()-1-i] - '0';
                sum.push_back((y^carry)?'1':'0');
                carry &= y;
            }
        }
        if(b.length() == first)
        {
            for(int i=first;i<a.length();i++)
            {
                int x = a[a.length()-1-i] - '0';
                sum.push_back((x^carry)?'1':'0');
                carry &= x;
            }
        }
        if(carry)sum.push_back('1');
        string ans = "";
        for(int i=sum.size()-1;i>=0;i--)
            ans += sum[i];
        return ans;
    }
};
