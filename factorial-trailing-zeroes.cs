public class Solution {
    public int TrailingZeroes(int n) {
        int count = 0;
        for(int i=n;i>=5;i/=5)count += i/5;
        return count;
    }
}
