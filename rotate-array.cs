public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] temp = new int[nums.Length];
        Array.Copy(nums,0,temp,0,nums.Length);
        for(int i=0;i<nums.Length;i++)
            nums[(i+k)%nums.Length] = temp[i];
    }
}
