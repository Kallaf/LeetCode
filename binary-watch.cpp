class Solution {
private:
    int on(int n)
    {
        int res = 0;
        for(int i=0;i<32;i++)
            res += (n>>i)&1;
        return res;
    }
public:
    vector<string> readBinaryWatch(int num) {
        vector<int> ons(62);
        for(int m=0;m<60;m++)
            ons[m] = on(m);
        vector<string> ans;
        for(int h=0;h<12;h++)
        {
            for(int m=0;m<60;m++)
            {
                if(ons[h]+ons[m] == num)
                    ans.push_back(to_string(h)+":"+(m<10?"0":"")+to_string(m));
            }   
        }
        return ans;
    }
};
