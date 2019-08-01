public class Solution {
    public uint reverseBits(uint n) {
        uint reverse = 0;
        for(int i=0;i<32;i++)
        {
            reverse <<= 1;
            reverse += n % 2;
            n >>= 1;
        }
        return reverse;
    }
}
