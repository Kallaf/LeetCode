class Solution {
    
    private int findMin(int[] nums) {
        if (nums.length == 1)return 0;
        int l = 0, r = nums.length - 1;
        if (nums[r] > nums[0])return 0;
        while (r >= l) {
          int mid = l + (r - l) / 2;
          if (nums[mid] > nums[mid + 1]) return mid + 1;
          if (nums[mid - 1] > nums[mid]) return mid;
          if (nums[mid] > nums[0])l = mid + 1;
          else r = mid - 1;
        }
        return -1;
    }
    
    public int search(int[] nums, int target) {
        if(nums.length == 0)return -1;
        int minIndex = findMin(nums);
        int right = Arrays.binarySearch(nums,minIndex,nums.length,target);
        if(right > -1)return right;
        int left = Arrays.binarySearch(nums,0,minIndex,target);
        if(left > -1)return left;
        return -1;
    }
}
