public class Solution {
    public int FindDuplicate(int[] nums) {
        int tortoise,hare;
        tortoise = hare = nums[0];
        do {
          tortoise = nums[tortoise];
          hare = nums[nums[hare]];
        } while (tortoise != hare);
        
        tortoise = nums[0];
        while (tortoise != hare) {
          tortoise = nums[tortoise];
          hare = nums[hare];
        }
        return tortoise;
    }
}
