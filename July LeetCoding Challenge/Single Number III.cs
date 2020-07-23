public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xor = 0;
        foreach(int num in nums)
            xor ^= num;
        int flag = 1;
        while((flag&xor) == 0)
            flag <<= 1;
        int a = 0;
        foreach(int num in nums)
            if((flag&num) != 0)
                a ^= num;
        return new int[]{a,xor^a};
    }
}
