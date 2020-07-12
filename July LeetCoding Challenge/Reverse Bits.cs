public class Solution {
    public uint reverseBits(uint n) {
        uint rev = 0;
        for(int i=0;i<32;i++)
        {
            rev <<= 1;
            rev += n&1;
            n >>= 1;
        }
        return rev;
    }
}
