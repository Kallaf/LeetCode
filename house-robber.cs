public class Solution {
    
    public int Rob(int[] nums) {
        if(nums.Length == 0)return 0;
        if(nums.Length == 1)return nums[0];
        int[] sum = new int[nums.Length+1];
        sum[0] = nums[0];
        sum[1] = Math.Max(nums[0],nums[1]);
        for(int i=2;i<nums.Length;i++)
            sum[i] = Math.Max(sum[i-1],sum[i-2]+nums[i]);
        return Math.Max(sum[nums.Length-1],sum[nums.Length-2]);
    }
}
