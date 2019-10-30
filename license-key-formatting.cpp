class Solution {
public:
    string licenseKeyFormatting(string str, int K) {
        str.erase(std::remove(str.begin(), str.end(), '-'), str.end());
        std::for_each(str.begin(), str.end(), [](char & c) {
            c = ::toupper(c);
        });
        int m = str.length()%K;
        string res = str.substr(0,m?m:K);
        for(int i=res.length();i<str.length();i+=K)
        {
            res += '-';
            for(int j=0;j<K;j++)
                res += str[i+j];
        }
        return res;
    }
};
