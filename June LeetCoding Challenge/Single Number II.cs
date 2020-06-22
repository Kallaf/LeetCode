public class Solution {
    public int SingleNumber(int[] nums) {
        int ones = 0, twos = 0, threes = 0;
        foreach(int num in nums) {
            twos |= (ones & num);
            ones ^= num;
            threes = ones & twos;
            ones &= ~threes;
            twos &= ~threes;
        }
        return ones;
    }
}
