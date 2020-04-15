class Solution {
    private int n;
    private int[] arr;
    private int getNext(int idx,int prev)
    {
        if(idx == n)
            return 1;
        int temp = arr[idx];
        arr[idx] = prev;
        int next = getNext(idx+1,prev*temp);
        arr[idx] *= next;
        return temp * next;
    }
    public int[] productExceptSelf(int[] nums) {
        n = nums.length;
        arr = nums;
        getNext(0,1);
        return nums;   
    }
}
