public class Solution {
    public int ArrangeCoins(int n) {
        return (int)(-1 + Math.Sqrt(1 + 8 * (long)n)) / 2;
    }
}
