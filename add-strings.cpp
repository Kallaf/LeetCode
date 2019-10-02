class Solution {
public:
    string addStrings(string num1, string num2) {
        string sum = "";
        bool carry = false;
        int i=num1.size()-1,j=num2.size()-1;
        for(;i>=0&&j>=0;i--,j--)
        {
            int num = num1[i] + num2[j] - 2*'0' + carry;
            carry = num > 9;
            num %= 10;
            sum += (char)(num+'0');
        }
        for(;i>=0;i--)
        {
            int num = num1[i] - '0' + carry;
            carry = num > 9;
            num %= 10;
            sum += (char)(num+'0');
        }
        for(;j>=0;j--)
        {
            int num = num2[j] - '0' + carry;
            carry = num > 9;
            num %= 10;
            sum += (char)(num+'0');
        }
        if(carry) sum += "1";
        reverse(sum.begin(),sum.end());
        return sum;
    }
};
