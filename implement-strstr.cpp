class Solution {
public:
    int strStr(string haystack, string needle) {
        int l1 = haystack.size(),l2=needle.size();
        for(int i=0;i<l1-l2+1;i++)
        {
            int count = 0;
            for(int j=0,ii=i;j<l2;j++,ii++)
            {
                if(haystack.at(ii) != needle.at(j))
                    break;
                count++;
            }
            if(count == l2)
                return i;
        }
        return -1;
    }
};
