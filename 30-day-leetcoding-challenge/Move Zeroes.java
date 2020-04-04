class Solution {
    public void moveZeroes(int[] nums) {
        int firstZero = -1;
        for(int i=0;i<nums.length;i++)
        {
            if(nums[i] != 0){
                if(firstZero != -1){
                    int temp = nums[i];
                    nums[i] = nums[firstZero];
                    nums[firstZero] = temp;
                    firstZero++;   
                }
            }else if(firstZero == -1)
                    firstZero = i;
        }
    }
}
