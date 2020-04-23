class Solution {
    public int rangeBitwiseAnd(int m, int n) {
        int res = 0;
        for(int i=31;i>=0;i--)
        {
            if((m >> i) == (n >> i))
              res += m & (1 << i);
            else break;
        }
        return res;
    }
}
