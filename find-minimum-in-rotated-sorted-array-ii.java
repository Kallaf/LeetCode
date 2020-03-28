class Solution {
    
  public int findMin(int[] nums) {
      if(nums.length == 0)return -1;
      int mn = nums[0];
      for(int num:nums)
          mn = Math.min(num,mn);
      return mn;
  }
}
