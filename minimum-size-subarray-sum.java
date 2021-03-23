class Solution {
    public int minSubArrayLen(int target, int[] nums) {
        int l = 0, r = nums.length;
        while (l < r) {
            int mid = l + (r-l)/2;
            if (isPossibleAnswer(mid+1, target, nums)) {
                r = mid;
            } else {
                l = mid + 1;   
            }
        }
        return l == nums.length ? 0: l+1;
    }
    
    public boolean isPossibleAnswer(int answer, int target, int[] nums) {
        int windowSum = 0;
        for (int i=0; i<answer; i++) {
            windowSum += nums[i];
            if (windowSum >= target) {
                return true;
            }
        }
        for (int i=answer; i<nums.length; i++) {
            windowSum += nums[i] - nums[i-answer];
            if (windowSum >= target) {
                return true;
            }
        }
        return false;
    }
}
