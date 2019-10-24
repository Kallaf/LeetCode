class Solution {
private:
    int bits(int x)
    {
        int cnt = 0;
        while(x)
        {
            if(x&1)cnt++;
            x>>=1;
        }
        return cnt;
    }
public:
    int hammingDistance(int x, int y) {
           return bits(x^y);
    }
};
