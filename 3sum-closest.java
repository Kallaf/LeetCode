class Solution {
    public int threeSumClosest(int[] nums, int target) {
        Arrays.sort(nums);
        int minDiff = Integer.MAX_VALUE;
        int ans = 0;
        for (int i=0; i<nums.length; i++) {
            for (int j=nums.length-1; j>i+1; j--) {
                int k = binarySearch(i+1, j, target - nums[i] - nums[j], nums);
                int sum = nums[i] + nums[j] + nums[k];
                int diff = Math.abs(target - sum);
                if (diff < minDiff) {
                    ans = sum;
                    minDiff = diff;
                }
            }
        }
        return ans;
    }
    
    private int binarySearch(int left, int right, int target, int[] nums) {
        int mid = left + (right - left) / 2;
        while (left + 1 < right) {
            if (nums[mid] < target) left = mid;
            else if (nums[mid] > target) right = mid;
            else break;
            mid = left + (right - left) / 2;
        }
        return mid;
    }
}
