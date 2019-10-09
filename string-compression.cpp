class Solution {
public:
    int compress(vector<char>& chars) {
        if(chars.empty())return 0;
        int k = 1,j=1,i=1;
        for(;i<chars.size();i++)
        {
            if(chars[i] == chars[i-1])
                j++;
            else{
                    chars[k-1] = chars[i-1];
                if(j>1)
                {
                    string num = to_string(j);
                    for(int l=0;l<num.length();l++)
                        chars[k++] = num[l];
                }
                k++;
                j = 1;
            }
        }
        chars[k-1] = chars[i-1];
        if(j>1)
        {
            string num = to_string(j);
            for(int l=0;l<num.length();l++)
                chars[k++] = num[l];
        }
        chars.erase(chars.begin()+k,chars.end());
        return chars.size();
    }
};
