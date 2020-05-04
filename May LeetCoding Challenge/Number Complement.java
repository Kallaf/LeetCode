class Solution {
    public int findComplement(int num) {
        int res = 0,i=0;
        while(num > 0)
        {
            res += (1-(num & 1)) << i;
            num >>= 1;
            i++;
        }
        return res;
    }
}
