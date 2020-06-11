public class Solution {
    public void SortColors(int[] nums) {
        int left=0,right=nums.Length-1;
        for(left=0;left < nums.Length && nums[left] == 0;left++);
        for(right=nums.Length-1;right >= 0 && nums[right] == 2;right--);
        for(int i=left;i<=right;i++)
        {
            for(;right >= 0 && nums[right] == 2;right--);
            if(right > i && nums[i] == 2)
            {
                int tempswap = nums[i];  
                nums[i] = nums[right];  
                nums[right] = tempswap;
            }
            
            
            for(;left < nums.Length && nums[left] == 0;left++);
            if(left < i && nums[i] == 0)
            {
                int tempswap = nums[i];  
                nums[i] = nums[left];  
                nums[left] = tempswap;
            }
        }
    }
}
