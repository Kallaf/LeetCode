class Solution {
    public boolean canJump(int[] nums) {
        for(int i=0,j=0;i<nums.length;i++)
            if(j >= i) j = Math.max(i+nums[i],j);
            else return false;
        return true;
    }
}
