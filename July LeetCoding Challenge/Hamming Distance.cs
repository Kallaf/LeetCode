public class Solution {
    public int HammingDistance(int x, int y) {
        x ^= y;
        y = 0;
        while(x>0)
        {
            y += x&1;
            x >>=1;
        }
        return y;
    }
}
